using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_NetServiceRecoveryFailed
    /// </summary>
    [WmiClass(Name = "MSFT_NetServiceRecoveryFailed")]
    public class MsftNetServiceRecoveryFailed
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// WMI Property ActionType
        /// </summary>
        public uint ActionType { get; set; }

        /// <summary>
        /// WMI Property Error
        /// </summary>
        public uint Error { get; set; }

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
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong MsftTimeCreated { get; set; }
    }
}