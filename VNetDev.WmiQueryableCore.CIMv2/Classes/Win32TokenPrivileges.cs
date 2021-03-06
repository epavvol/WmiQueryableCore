using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_TokenPrivileges
    /// </summary>
    [WmiClass(Name = "Win32_TokenPrivileges")]
    public class Win32TokenPrivileges
    {
        /// <summary>
        /// WMI Property PrivilegeCount
        /// </summary>
        public uint PrivilegeCount { get; set; }

        /// <summary>
        /// WMI Property Privileges
        /// </summary>
        public ICollection<object> Privileges { get; set; }
    }
}