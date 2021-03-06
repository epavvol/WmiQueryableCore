using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_TokenGroups
    /// </summary>
    [WmiClass(Name = "Win32_TokenGroups")]
    public class Win32TokenGroups
    {
        /// <summary>
        /// WMI Property GroupCount
        /// </summary>
        public uint GroupCount { get; set; }

        /// <summary>
        /// WMI Property Groups
        /// </summary>
        public ICollection<object> Groups { get; set; }
    }
}