using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VNetDev.WmiQueryableCore.Contracts;
using System.Management;
using System.Reflection;
using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.DCom.Extensions;
using VNetDev.WmiQueryableCore.Exceptions;
using VNetDev.WmiQueryableCore.WqlTranslator;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.DCom
{
    /// <summary>
    /// WMI Query Connection via DCom
    /// </summary>
    public class DComConnection : IWmiConnection, IDisposable
    {
        private ManagementScope _connection;
        private bool _disposed;
        private WmiContext _context;
        private readonly Dictionary<object, ManagementObject> _instances = new Dictionary<object, ManagementObject>();
        private readonly IWqlFactory _wqlFactory = new WqlFactory();

        #region Constructors

        /// <summary>
        /// Constructor that takes preconfigured <c>ManagementScope</c> and WMI namespace
        /// </summary>
        /// <param name="connection">Preconfigured <c>ManagementScope</c> object</param>
        public DComConnection(ManagementScope connection)
        {
            _connection = connection;
            if (!_connection.IsConnected)
            {
                _connection.Connect();
            }
        }

        /// <summary>
        /// Constructor that configures connection to host using current credentials and takes WMI namespace
        /// </summary>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">Namespace to configure</param>
        public DComConnection(string computerName = "localhost", string nameSpace = @"root\CIMv2")
            => CreateDComConnection(computerName, nameSpace);


        /// <summary>
        /// Constructor that configures connection to host using specified credential object and takes WMI namespace
        /// </summary>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">Namespace to configure</param>
        /// <param name="options">Preconfigured <c>ConnectionOptions</c> object</param>
        public DComConnection(string computerName, string nameSpace, ConnectionOptions options)
            => CreateDComConnection(computerName, nameSpace, options);

        /// <summary>
        /// Constructor that configures connection to host using specified credentials and takes WMI namespace
        /// </summary>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">Namespace to configure</param>
        /// <param name="impersonationLevel">Impersonation Level</param>
        /// <param name="domain">User domain</param>
        /// <param name="userName">User name</param>
        /// <param name="password">User password</param>
        public DComConnection(string computerName, string nameSpace, string domain, string userName, string password,
            ImpersonationLevel impersonationLevel = ImpersonationLevel.Impersonate)
            => CreateDComConnection(computerName, nameSpace, new ConnectionOptions
            {
                EnablePrivileges = true,
                Impersonation = impersonationLevel,
                Username = $"{domain}\\{userName}",
                Password = password
            });

        #endregion

        private void CreateDComConnection(string computerName, string nameSpace, ConnectionOptions options = null)
            => (_connection = options == null
                ? new ManagementScope($"\\\\{computerName}\\{nameSpace}")
                : new ManagementScope($"\\\\{computerName}\\{nameSpace}", options)).Connect();

        internal T InvokeDComMethod<T>(object wmiClass, string methodName,
            IDictionary<string, object> parameters)
        {
            var arguments = new object[parameters.Count];
            var i = 0;
            foreach (var p in parameters)
            {
                arguments[i++] = ManagementObjectTypeConverter.ToWmiType(p.Value);
            }

            var objectInstance = _instances.ContainsKey(wmiClass)
                ? _instances[wmiClass]
                : throw new NotSupportedException("Provided instance of WMI class is not registered!");

            return (T) objectInstance.InvokeMethod(
                methodName,
                arguments);
        }

        /// <summary>
        /// Executes static method of WMI class
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <typeparam name="TClass">WMI Class type</typeparam>
        /// <param name="methodName">Name of WMI method to be executed</param>
        /// <param name="methodParameters">WMI Method parameters</param>
        /// <returns>Method execution result of type <c>T</c></returns>
        public T InvokeStaticMethod<T, TClass>(
            string methodName, IDictionary<string, object> methodParameters)
        {
            var wmiClass = typeof(TClass);
            var className = wmiClass.GetCustomAttribute<WmiClassAttribute>()?
                .Name ?? wmiClass.Name;
            var managementClass = new ManagementClass(
                _connection,
                new ManagementPath(className),
                new ObjectGetOptions());

            var parameters = managementClass.GetMethodParameters(methodName);

            foreach (var parameter in methodParameters)
            {
                if (parameter.Value == null)
                    continue;
                parameters[parameter.Key] = ManagementObjectTypeConverter.ToWmiType(parameter.Value);
            }

            var returnPropertyName = _context
                                         .GetType()
                                         .GetCustomAttribute<WmiContextAttribute>()?
                                         .MethodDefaultReturnProperty
                                     ?? "ReturnValue";

            var resultValue = managementClass.InvokeMethod(
                methodName,
                parameters,
                null)?[returnPropertyName];
            if (resultValue == null)
            {
                return default;
            }

            return (T) resultValue;
        }

        /// <summary>
        /// Creates new instance of WMI object
        /// </summary>
        /// <typeparam name="T">WMI Class Type</typeparam>
        /// <returns>Created WMI object instance</returns>
        public T CreateInstance<T>()
        {
            var objectType = typeof(T);
            var className = objectType.GetCustomAttribute<WmiClassAttribute>()?
                .Name ?? objectType.Name;
            var managementClass = new ManagementClass(
                _connection,
                new ManagementPath(className),
                new ObjectGetOptions());

            return new ObjectReader<T>(
                    new[]
                    {
                        managementClass
                    },
                    this,
                    null,
                    typeof(T))
                .First();
        }

        /// <summary>
        /// Close the connection
        /// </summary>
        public void Close()
        {
            _connection = null;
            _disposed = true;
        }

        /// <summary>
        /// Test the connection
        /// </summary>
        /// <returns>true if connection alive, otherwise false</returns>
        public bool TestConnection() => _connection?.IsConnected ?? false;

        /// <summary>
        /// Test the connection asynchronously
        /// </summary>
        /// <returns>true if connection alive, otherwise false</returns>
        public Task<bool> TestConnectionAsync() => Task.Factory
            .StartNew(() => _connection.IsConnected);

        /// <summary>
        /// Closing connection and disposing object
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(ManagementScope));
            }

            Close();
        }

        /// <summary>
        /// Sets WMI context instance for WMI Query provider
        /// </summary>
        /// <param name="context">WMIContext instance</param>
        public void SetContext(WmiContext context)
        {
            if (_context != null)
            {
                throw new WmiContextReassignmentException(nameof(WmiContext));
            }

            _context = context ?? throw new ArgumentNullException(nameof(WmiContext));
        }

        /// <summary>
        /// Checks that WMI Query provider has WMI context configured
        /// </summary>
        /// <returns>true if WMI context configured, otherwise false</returns>
        public bool HasContext() => _context != null;

        /// <summary>
        /// Creates Query object from LINQ expression provided
        /// </summary>
        /// <param name="expression">LINQ Expression</param>
        /// <returns>Non-generic IQueryable object</returns>
        public IQueryable CreateQuery(Expression expression) =>
            new WmiClassSet<object>(_context, expression);

        /// <summary>
        /// Creates Query object from LINQ expression provided
        /// </summary>
        /// <param name="expression">LINQ Expression</param>
        /// <returns>Generic IQueryable object</returns>
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression) =>
            new WmiClassSet<TElement>(_context, expression);

        /// <summary>
        /// Executes query and returns WMI object instances
        /// </summary>
        /// <param name="expression">LINQ expression</param>
        /// <returns>Query result as object</returns>
        public object Execute(Expression expression)
        {
            var translationResult = _wqlFactory.TranslateQuery(expression);
            var allInstances = new ManagementObjectSearcher(
                    _connection,
                    new ObjectQuery(translationResult.ToString()))
                .Get()
                .Cast<ManagementObject>();

            if (expression is MethodCallExpression methodCallExpression)
            {
                var returnInstanceType = methodCallExpression.Type;
                ManagementObject instance;
                ManagementObject[] instances;
                switch (methodCallExpression.Method.Name)
                {
                    case "Count":
                        return allInstances.Count();
                    case "First":
                        instance = allInstances.FirstOrDefault();
                        if (instance == null)
                        {
                            throw new InvalidOperationException("No object found!");
                        }

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instance}).FirstOrDefault();
                    case "FirstOrDefault":
                        instance = allInstances.FirstOrDefault();
                        if (instance == null)
                        {
                            return null;
                        }

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instance}).FirstOrDefault();
                    case "Single":
                        instances = allInstances.ToArray();
                        if (instances.Length != 1)
                        {
                            throw new InvalidOperationException("No single object found!");
                        }

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instances}).FirstOrDefault();
                    case "SingleOrDefault":
                        instances = allInstances.ToArray();
                        if (instances.Length != 1)
                        {
                            return null;
                        }

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instances.First()}).FirstOrDefault();
                    default:
                        return CreateObjectInstances(
                            returnInstanceType.GetGenericArguments()[0],
                            translationResult,
                            allInstances);
                }
            }

            return CreateObjectInstances(expression.Type.GenericTypeArguments[0], translationResult,
                allInstances);
        }

        private IEnumerable<object> CreateObjectInstances(Type type, IWqlQuery queryObject,
            IEnumerable instances)
        {
            return (IEnumerable<object>) Activator.CreateInstance(
                typeof(ObjectReader<>).MakeGenericType(type),
                instances,
                this,
                queryObject,
                null);
        }


        /// <summary>
        /// Executes query and returns WMI object instances
        /// </summary>
        /// <typeparam name="TResult">Type of result</typeparam>
        /// <param name="expression">LINQ expression</param>
        /// <returns>Query result in appropriate type</returns>
        public TResult Execute<TResult>(Expression expression) =>
            (TResult) Execute(expression);

        /// <summary>
        /// Deletes tracked WMI object instance
        /// </summary>
        /// <param name="wmiClass">instance to be deleted</param>
        public void Delete(object wmiClass)
        {
            if (!_instances.ContainsKey(wmiClass))
            {
                throw new WmiObjectNotRegisteredException();
            }

            _instances[wmiClass].Delete();
            _instances.Remove(wmiClass);
        }

        /// <summary>
        /// Deletes tracked WMI object instance asynchronously
        /// </summary>
        /// <param name="wmiClass">instance to be deleted</param>
        public Task DeleteAsync(object wmiClass) => Task.Run(() =>
        {
            if (!_instances.ContainsKey(wmiClass))
            {
                throw new WmiObjectNotRegisteredException();
            }

            _instances[wmiClass].Delete();
            _instances.Remove(wmiClass);
        });

        internal void RegisterInstance(object wmiClass, ManagementObject objectInstance)
        {
            _instances[wmiClass] = objectInstance;
        }
    }
}