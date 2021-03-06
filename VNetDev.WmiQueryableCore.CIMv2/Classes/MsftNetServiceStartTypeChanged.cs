using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_NetServiceStartTypeChanged
    /// </summary>
    [WmiClass(Name = "MSFT_NetServiceStartTypeChanged")]
    public class MsftNetServiceStartTypeChanged
    {
        /// <summary>
        /// WMI Property NewStartType
        /// </summary>
        public string NewStartType { get; set; }

        /// <summary>
        /// WMI Property OldStartType
        /// </summary>
        public string OldStartType { get; set; }

        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> MsftSecurityDescriptor { get; set; }

        /// <summary>
        /// WMI Property Service
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// WMI Property sid
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong MsftTimeCreated { get; set; }
    }
}