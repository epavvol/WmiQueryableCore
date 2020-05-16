using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNetDev.WmiQueryableCore.Contracts
{
    /// <summary>
    /// Interface that describes WMI Query connection members
    /// </summary>
    public interface IWmiConnection : IQueryProvider
    {
        /// <summary>
        /// Close the connection
        /// </summary>
        void Close();

        /// <summary>
        /// Test the connection
        /// </summary>
        /// <returns>true if connection active, otherwise false</returns>
        bool TestConnection();

        /// <summary>
        /// Test the connection asynchronously
        /// </summary>
        /// <returns>true if connection active, otherwise false</returns>
        Task<bool> TestConnectionAsync();

        /// <summary>
        /// Delete tracked WMI object instance
        /// </summary>
        /// <param name="wmiCLass">WMI object instance</param>
        void Delete(object wmiCLass);

        /// <summary>
        /// Delete tracked WMI object instance asynchronously
        /// </summary>
        /// <param name="wmiCLass">WMI object instance</param>
        Task DeleteAsync(object wmiCLass);

        /// <summary>
        /// Sets WMI context instance for WMI Query provider
        /// </summary>
        /// <param name="context">WMIContext instance</param>
        void SetContext(WmiContext context);

        /// <summary>
        /// Checks that WMI Query provider has WMI context configured
        /// </summary>
        /// <returns>true if WMI context configured, otherwise false</returns>
        bool HasContext();

        /// <summary>
        /// Creates new instance of WMI object
        /// </summary>
        /// <typeparam name="T">WMI Class Type</typeparam>
        /// <returns>Created WMI object instance</returns>
        T CreateInstance<T>();

        /// <summary>
        /// Executes static method of WMI class
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <typeparam name="TClass">WMI Class type</typeparam>
        /// <param name="methodName">Name of WMI method to be executed</param>
        /// <param name="methodParameters">WMI Method parameters</param>
        /// <returns>Method execution result of type <c>T</c></returns>
        T InvokeStaticMethod<T, TClass>(string methodName, IDictionary<string, object> methodParameters);
    }
}