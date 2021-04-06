using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.Contracts;

namespace VNetDev.WmiQueryableCore
{
    /// <summary>
    /// WMI Context base class
    /// </summary>
    public class WmiContext :
        IDisposable
    {
        private WmiContextOptions _options;
        private bool _disposed;
        private IWmiConnection _connection;

        /// <summary>
        /// WMI Connection
        /// </summary>
        public IWmiConnection Connection => _connection ?? (_connection = _options.Connection);

        #region Properties

        /// <summary>
        /// Returns WMI Context options
        /// </summary>
        /// <returns>WMI Context</returns>
        public WmiContextOptions GetOptions() => _options;

        /// <summary>
        /// Property indicates that Context has been configured and connection object registered
        /// </summary>
        public bool IsConfigured => _options?.Connection != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public WmiContext()
        {
        }

        /// <summary>
        /// Constructor that registers WMI Context options and initializes WMI class collections
        /// </summary>
        /// <param name="options"></param>
        public WmiContext(WmiContextOptions options)
        {
            _options = options ??
                       throw new InvalidOperationException("WmiContext options cannot be null!");
            _options.Connection?.SetContext(this);
            CreateClassSets();
        }

        #endregion

        #region Configuration methods

        /// <summary>
        /// Configures WMI Context using class options builder provided and initializes WMI class collections
        /// </summary>
        /// <typeparam name="TWmiContextOptionsBuilder">Options builder to be used</typeparam>
        /// <param name="optionsAction">Actions to configure options before connection</param>
        public void Configure<TWmiContextOptionsBuilder>(
            Action<TWmiContextOptionsBuilder> optionsAction)
            where TWmiContextOptionsBuilder : WmiContextOptionsBuilder, new()
        {
            if (_disposed || IsConfigured)
            {
                throw new InvalidOperationException(
                    "This context cannot be configured anymore.");
            }

            var builder = new TWmiContextOptionsBuilder();
            if (_options != null)
            {
                builder.Options = _options;
            }

            optionsAction?.Invoke(builder);
            _options = builder.Options;
            _options.Connection?.SetContext(this);
            CreateClassSets();
        }

        /// <summary>
        /// Configures WMI Context using default options builder and initializes WMI class collections
        /// </summary>
        /// <param name="optionsAction">Actions to configure options before connection</param>
        public void Configure(Action<WmiContextOptionsBuilder> optionsAction) =>
            Configure<WmiContextOptionsBuilder>(optionsAction);

        private void CreateClassSets()
        {
            foreach (var propertyInfo in GetType()
                .GetProperties()
                .Where(t => t.PropertyType.IsGenericType &&
                            t.PropertyType.GetGenericTypeDefinition() == typeof(WmiClassSet<>)))
            {
                propertyInfo.SetValue(
                    this,
                    Activator.CreateInstance(
                        propertyInfo.PropertyType,
                        this));
                var wmiClassType = propertyInfo.PropertyType.GetGenericArguments().FirstOrDefault();
                if (wmiClassType != null)
                    SetStaticMethods(wmiClassType);
            }
        }

        internal T CreateObjectInstance<T>() => Connection.CreateInstance<T>();

        internal void SaveObjectInstance<T>(T instance) =>
            throw new NotImplementedException(nameof(SaveObjectInstance) + " is not implemented!");

        internal void DeleteObjectInstance<T>(T instance) => Connection.Delete(instance);

        private static T InvokeStaticMethod<T, TClass>(WmiContext wmiContext, string methodName,
            IDictionary<string, object> methodParameters) =>
            wmiContext.Connection == null
                ? default
                : wmiContext.Connection.InvokeStaticMethod<T, TClass>(methodName, methodParameters);

        private static readonly MethodInfo InvokeStaticMethodInfo = typeof(WmiContext)
            .GetMethod(nameof(InvokeStaticMethod), BindingFlags.Static | BindingFlags.NonPublic);

        private static void SetStaticMethods(Type wmiClassType)
        {
            foreach (var staticMethod in wmiClassType
                .GetFields(BindingFlags.Static | BindingFlags.Public)
                .Where(f => f.FieldType.IsSubclassOf(typeof(Delegate))))
            {
                // Check if class has field that is already assigned
                if (staticMethod.GetValue(null) != null)
                    return;
                // Getting Invoke method of the field and check if it is not null
                var invokeMethod = staticMethod.FieldType.GetMethod("Invoke");
                if (invokeMethod == null)
                    continue;
                // Getting all method parameters, checking if it has at least one and the first is WmiContext
                var invokeMethodParameters = invokeMethod.GetParameters();
                if (invokeMethodParameters.Length < 1 ||
                    !typeof(WmiContext).IsAssignableFrom(invokeMethodParameters[0].ParameterType))
                    continue;

                var parametersDictionaryType = typeof(Dictionary<string, object>);
                var addToDictionaryMethod = parametersDictionaryType.GetMethod(nameof(Dictionary<string, object>.Add));
                if (addToDictionaryMethod == null)
                    continue;

                var wmiMethodName = staticMethod.GetCustomAttributes<WmiMethodAttribute>()
                                        .Select(a => a.Name)
                                        .FirstOrDefault(a => !string.IsNullOrWhiteSpace(a)) ??
                                    staticMethod.Name;

                var newDictionaryExpression = Expression.New(parametersDictionaryType);
                var lambdaParameters = new ParameterExpression[invokeMethodParameters.Length];
                var listInitParameters = new ElementInit[invokeMethodParameters.Length - 1];
                for (var i = 0; i < invokeMethodParameters.Length; i++)
                {
                    var parameter = invokeMethodParameters[i];
                    lambdaParameters[i] = Expression.Parameter(parameter.ParameterType, parameter.Name);
                    if (i == 0)
                        continue;
                    listInitParameters[i - 1] = Expression.ElementInit(addToDictionaryMethod,
                        Expression.Constant(parameter.Name),
                        Expression.Convert(lambdaParameters[i], typeof(object)));
                }

                var invokeCimMethodCallExpression = Expression.Call(
                    null,
                    InvokeStaticMethodInfo.MakeGenericMethod(invokeMethod.ReturnType, wmiClassType),
                    lambdaParameters[0],
                    Expression.Constant(wmiMethodName),
                    Expression.ListInit(newDictionaryExpression, listInitParameters));

                var lambdaExpression = Expression.Lambda(
                    staticMethod.FieldType,
                    invokeCimMethodCallExpression,
                    lambdaParameters);

                staticMethod.SetValue(null, lambdaExpression.Compile());
            }
        }

        #endregion

        #region IDisposable interface implementation

        /// <summary>
        /// Disposes connection and context
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            Connection?.Close();
            _disposed = true;
        }

        /// <summary>
        /// Checks that context and connections are disposed
        /// <exception cref="ObjectDisposedException">Throws if object is disposed</exception>
        /// </summary>
        [DebuggerStepThrough]
        public void CheckDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("WmiContext disposed!");
            }
        }

        #endregion
    }
}