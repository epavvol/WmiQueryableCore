using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Reflection;
using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.DCom.Extensions;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.DCom
{
    internal class ObjectReader<T> : IEnumerable<T>
    {
        private Enumerator _enumerator;

        public ObjectReader(IEnumerable collection, DComConnection connection, IWqlQuery queryObject,
            Type outType = null)
        {
            _enumerator = new Enumerator(collection.Cast<ManagementObject>(), connection, queryObject, outType);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var e = _enumerator;
            if (e == null)
            {
                throw new InvalidOperationException("Cannot enumerate more than once");
            }

            _enumerator = null;
            return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator : IEnumerator<T>
        {
            private readonly IEnumerator<ManagementObject> _collection;
            private readonly DComConnection _connection;
            private readonly IWqlQuery _queryObject;
            private readonly Type _outType;
            private readonly ConstantExpression _connectionExpression;

            public T Current { get; private set; }

            internal Enumerator(IEnumerable<ManagementObject> collection, DComConnection connection,
                IWqlQuery queryObject, Type outType)
            {
                if (queryObject == null && outType == null)
                {
                    throw new ArgumentException(
                        $"Both {nameof(queryObject)} and {nameof(outType)} cannot be null at the same time.");
                }

                _connection = connection;
                _collection = collection.GetEnumerator();
                _queryObject = queryObject;
                _connectionExpression = Expression.Constant(connection);
                _outType = outType;
            }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (!_collection.MoveNext())
                {
                    return false;
                }

                var currentObject = Activator.CreateInstance(_outType ?? _queryObject.WqlQueryResultType);

                _connection.RegisterInstance(currentObject, _collection.Current);

                var currentObjectType = currentObject.GetType();
                foreach (var property in currentObjectType.GetProperties())
                {
                    if (currentObjectType.GetProperty(property.Name)?
                        .GetCustomAttribute<WmiIgnorePropertyAttribute>(false) != null)
                    {
                        continue;
                    }

                    var objectPropertyAttribute = currentObjectType
                        .GetProperty(property.Name)?
                        .GetCustomAttribute<WmiPropertyAttribute>(false);
                    var propertyName = objectPropertyAttribute?.Name ?? property.Name;
                    property.SetValue(
                        currentObject,
                        _collection.Current.GetWmiValue(property.PropertyType, propertyName));
                }

                var members = currentObjectType
                    .GetFields(BindingFlags.Instance | BindingFlags.Public)
                    .Where(f => f.FieldType.IsSubclassOf(typeof(Delegate)))
                    .ToArray();

                var invokeCimMethodInfo = _connection
                    .GetType()
                    .GetMethod(
                        nameof(DComConnection.InvokeDComMethod),
                        BindingFlags.Instance | BindingFlags.NonPublic);

                if (invokeCimMethodInfo == null)
                {
                    throw new InvalidOperationException(_connection.GetType().Name +
                                                        " does not support cim method invoke operation.");
                }

                var classInstanceExpression = Expression.Constant(currentObject);
                var parametersDictionaryType = typeof(Dictionary<string, object>);
                var addToDictionaryMethod = parametersDictionaryType.GetMethod(nameof(Dictionary<string, object>.Add));
                if (addToDictionaryMethod == null)
                {
                    throw new InvalidOperationException(parametersDictionaryType.Name + " does not support list init!");
                }

                foreach (var member in members)
                {
                    var invokeMethod = member.FieldType.GetMethod("Invoke");

                    if (invokeMethod == null)
                    {
                        continue;
                    }

                    var wmiMethodName = member.GetCustomAttributes<WmiMethodAttribute>().Select(a => a.Name)
                                            .FirstOrDefault(a => !string.IsNullOrWhiteSpace(a)) ??
                                        member.Name;

                    var invokeMethodParameters = invokeMethod.GetParameters();

                    var newDictionaryExpression = Expression.New(parametersDictionaryType);
                    var lambdaParameters = new ParameterExpression[invokeMethodParameters.Length];
                    var listInitParameters = new ElementInit[invokeMethodParameters.Length];

                    for (var i = 0; i < invokeMethodParameters.Length; i++)
                    {
                        var parameter = invokeMethodParameters[i];
                        lambdaParameters[i] = Expression.Parameter(parameter.ParameterType, parameter.Name);

                        listInitParameters[i] = Expression.ElementInit(addToDictionaryMethod,
                            Expression.Constant(parameter.Name),
                            Expression.Convert(lambdaParameters[i], typeof(object)));
                    }

                    var invokeCimMethodCallExpression = Expression.Call(
                        _connectionExpression,
                        invokeCimMethodInfo.MakeGenericMethod(invokeMethod.ReturnType),
                        classInstanceExpression,
                        Expression.Constant(wmiMethodName),
                        Expression.ListInit(newDictionaryExpression, listInitParameters));

                    var lambdaExpression = Expression.Lambda(member.FieldType, invokeCimMethodCallExpression,
                        lambdaParameters);

                    member.SetValue(currentObject, lambdaExpression.Compile());
                }

                Current = (T)(_queryObject == null ? currentObject : _queryObject.ProceedDelegates(currentObject));

                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException("Reset is not supported!");
            }

            public void Dispose()
            {
                _collection.Dispose();
            }
        }
    }
}