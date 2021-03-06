using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PrivilegesStatus
    /// </summary>
    [WmiClass(Name = "Win32_PrivilegesStatus")]
    public class Win32PrivilegesStatus
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Operation
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// WMI Property ParameterInfo
        /// </summary>
        public string ParameterInfo { get; set; }

        /// <summary>
        /// WMI Property PrivilegesNotHeld
        /// </summary>
        public ICollection<string> PrivilegesNotHeld { get; set; }

        /// <summary>
        /// WMI Property PrivilegesRequired
        /// </summary>
        public ICollection<string> PrivilegesRequired { get; set; }

        /// <summary>
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// WMI Property StatusCode
        /// </summary>
        public uint StatusCode { get; set; }
    }
}