using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using System.Threading.Tasks;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using VNetDev.WmiQueryableCore.Attributes;
using VNetDev.WmiQueryableCore.Contracts;
using VNetDev.WmiQueryableCore.Exceptions;
using VNetDev.WmiQueryableCore.WqlTranslator;
using VNetDev.WmiQueryableCore.WqlTranslator.Abstraction;

namespace VNetDev.WmiQueryableCore.Cim
{
    /// <summary>
    /// WMI Query Connection via Windows Remote Management
    /// </summary>
    public class CimConnection : IWmiConnection, IDisposable
    {
        private const string QueryDialect = "WQL";
        private readonly CimSession _connection;
        private readonly string _nameSpace;
        private WmiContext _context;
        private readonly IWqlFactory _wqlFactory = new WqlFactory();
        private readonly Dictionary<object, CimInstance> _instances = new Dictionary<object, CimInstance>();
        private bool _disposed;

        #region Constructors

        /// <summary>
        /// Constructor that takes preconfigured CimConnection and WMI namespace
        /// </summary>
        /// <param name="connection">Preconfigured CimSession connection</param>
        /// <param name="nameSpace">Namespace to configure</param>
        public CimConnection(CimSession connection, string nameSpace = @"root\CIMv2")
        {
            _connection = connection;
            _nameSpace = nameSpace;
        }

        /// <summary>
        /// Constructor that configures connection to host using current credentials and takes WMI namespace
        /// </summary>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">Namespace to configure</param>
        public CimConnection(string computerName = "localhost", string nameSpace = @"root\CIMv2") :
            this(CimSession.Create(computerName), nameSpace)
        {
        }

        /// <summary>
        /// Constructor that configures connection to host using specified credential object and takes WMI namespace
        /// </summary>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">Namespace to configure</param>
        /// <param name="credential">Preconfigured credential object to be used in connection</param>
        public CimConnection(string computerName, string nameSpace, CimCredential credential)
        {
            var sessionOptions = new WSManSessionOptions();
            sessionOptions.AddDestinationCredentials(credential);
            _connection = CimSession.Create(computerName, sessionOptions);
            _nameSpace = nameSpace;
        }

        /// <summary>
        /// Constructor that configures connection to host using specified credentials and takes WMI namespace
        /// </summary>
        /// <param name="computerName">Computer name or IP address to connect</param>
        /// <param name="nameSpace">Namespace to configure</param>
        /// <param name="authenticationMechanism">Authentication mechanism to be used</param>
        /// <param name="domain">User domain</param>
        /// <param name="userName">User name</param>
        /// <param name="password">User password</param>
        public CimConnection(string computerName, string nameSpace,
            PasswordAuthenticationMechanism authenticationMechanism, string domain, string userName, string password)
        {
            var securePassword = new SecureString();
            foreach (var c in password)
            {
                securePassword.AppendChar(c);
            }

            var credential = new CimCredential(authenticationMechanism, domain, userName, securePassword);
            var sessionOptions = new WSManSessionOptions();
            sessionOptions.AddDestinationCredentials(credential);
            _connection = CimSession.Create(computerName, sessionOptions);
            _nameSpace = nameSpace;
        }

        #endregion

        internal T InvokeCimMethod<T>(object wmiClass, string methodName,
            IDictionary<string, object> methodParameters)
        {
            var parameters = new CimMethodParametersCollection();
            foreach (var methodParameter in methodParameters)
            {
                parameters.Add(CimMethodParameter.Create(methodParameter.Key, methodParameter.Value, CimFlags.In));
            }

            var objectInstance = _instances.ContainsKey(wmiClass)
                ? _instances[wmiClass]
                : throw new NotSupportedException("Provided instance of WMI class is not registered!");

            return (T) _connection.InvokeMethod(
                objectInstance,
                methodName,
                parameters).ReturnValue.Value;
        }

        /// <summary>
        /// Executes static method of WMI class
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <typeparam name="TClass">WMI Class type</typeparam>
        /// <param name="methodName">Name of WMI method to be executed</param>
        /// <param name="methodParameters">WMI Method parameters</param>
        /// <returns>Method execution result of type <c>T</c></returns>
        public T InvokeStaticMethod<T, TClass>(string methodName, IDictionary<string, object> methodParameters)
        {
            var wmiClass = typeof(TClass);
            var parameters = new CimMethodParametersCollection();
            foreach (var methodParameter in methodParameters)
            {
                var val = methodParameter.Value;
                if(val == null)
                    continue;
                parameters.Add(CimMethodParameter.Create(methodParameter.Key, val, CimFlags.In));
            }

            return (T) _connection.InvokeMethod(
                _nameSpace,
                wmiClass.GetCustomAttribute<WmiClassAttribute>()?
                    .Name ?? wmiClass.Name,
                methodName,
                parameters).ReturnValue.Value;
        }

        /// <summary>
        /// Creates new instance of WMI object
        /// </summary>
        /// <typeparam name="T">WMI Class Type</typeparam>
        /// <returns>Created WMI object instance</returns>
        public T CreateInstance<T>()
        {
            var objectType = typeof(T);
            return new ObjectReader<T>(
                    new[]
                    {
                        _connection
                            .CreateInstance(_nameSpace, new CimInstance(
                                objectType
                                    .GetCustomAttribute<WmiClassAttribute>()?
                                    .Name ?? objectType.Name,
                                _nameSpace))
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
            _connection?.Close();
        }

        /// <summary>
        /// Test the connection
        /// </summary>
        /// <returns>true if connection alive, otherwise false</returns>
        public bool TestConnection() => _connection.TestConnection();

        /// <summary>
        /// Test the connection asynchronously
        /// </summary>
        /// <returns>true if connection alive, otherwise false</returns>
        public Task<bool> TestConnectionAsync() => Task.Factory
            .StartNew(() => _connection.TestConnection());

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

            _connection.DeleteInstance(
                _instances[wmiClass]);
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

            _connection.DeleteInstance(
                _instances[wmiClass]);
            _instances.Remove(wmiClass);
        });

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
        /// Closing connection and disposing object
        /// </summary>
        public void Dispose()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(CimConnection));
            }

            _connection?.Dispose();
            _disposed = true;
        }

        #region IQueryProvider interface implementation

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
        /// Creates object instances for WMI classes
        /// </summary>
        /// <param name="type">Object type</param>
        /// <param name="queryObject">Query representation object</param>
        /// <param name="instances">WMI instances to be used</param>
        /// <returns></returns>
        private IEnumerable<object> CreateObjectInstances(Type type, IWqlQuery queryObject,
            IEnumerable<CimInstance> instances)
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
        /// <param name="expression">LINQ expression</param>
        /// <returns>Query result as object</returns>
        public object Execute(Expression expression)
        {
            var translationResult = _wqlFactory.TranslateQuery(expression);
            Console.WriteLine(translationResult);

            var allInstances = _connection
                .QueryInstances(
                    _nameSpace,
                    QueryDialect,
                    translationResult.ToString());

            if (expression is MethodCallExpression methodCallExpression)
            {
                //var returnInstanceType = methodCallExpression.Arguments[0].Type.GetGenericArguments()[0];
                var returnInstanceType = methodCallExpression.Type;
                CimInstance instance;
                IList<CimInstance> instances;
                switch (methodCallExpression.Method.Name)
                {
                    case "Count":
                        return allInstances.Count();
                    case "First":
                        instance = allInstances.FirstOrDefault();
                        if (instance == null)
                            throw new InvalidOperationException("No object found!");

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instance}).First();
                    case "FirstOrDefault":
                        instance = allInstances.FirstOrDefault();
                        if (instance == null)
                            return null;

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instance}).First();
                    case "Single":
                        instances = allInstances.ToList();
                        if (instances.Count != 1)
                        {
                            throw new InvalidOperationException("No single object found!");
                        }

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instances.First()}).First();
                    case "SingleOrDefault":
                        instances = allInstances.ToList();
                        if (instances.Count != 1)
                        {
                            return null;
                        }

                        return CreateObjectInstances(
                            returnInstanceType,
                            translationResult,
                            new[] {instances[0]}).First();
                    default:
                        return CreateObjectInstances(
                            returnInstanceType.GetGenericArguments()[0],
                            translationResult,
                            allInstances);
                }
            }

            return CreateObjectInstances(
                expression.Type.GenericTypeArguments[0],
                translationResult,
                allInstances);
        }

        /// <summary>
        /// Executes query and returns WMI object instances
        /// </summary>
        /// <param name="expression">LINQ expression</param>
        /// <returns>Query result in appropriate type</returns>
        public TResult Execute<TResult>(Expression expression) =>
            (TResult) Execute(expression);

        #endregion

        internal void RegisterInstance(object wmiClass, CimInstance cimInstance)
        {
            _instances[wmiClass] = cimInstance;
        }
    }
}