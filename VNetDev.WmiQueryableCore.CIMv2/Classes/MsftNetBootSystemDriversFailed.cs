using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_NetBootSystemDriversFailed
    /// </summary>
    [WmiClass(Name = "MSFT_NetBootSystemDriversFailed")]
    public class MsftNetBootSystemDriversFailed
    {
        /// <summary>
        /// WMI Property DriverList
        /// </summary>
        public string DriverList { get; set; }

        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> MsftSecurityDescriptor { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong MsftTimeCreated { get; set; }
    }
}