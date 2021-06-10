using System;
using System.Security.Cryptography.X509Certificates;

namespace VNetDev.WmiQueryableCore.Attributes
{
    /// <summary>
    /// Attribute to configure additional options of WMI Context class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class WmiContextAttribute : Attribute
    {
        /// <summary>
        /// Default return property name to get value from delegate execution result.
        /// </summary>
        public string MethodDefaultReturnProperty { get; set; }
    }
}