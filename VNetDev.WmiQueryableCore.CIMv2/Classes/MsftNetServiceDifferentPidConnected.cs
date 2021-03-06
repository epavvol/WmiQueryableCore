using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_NetServiceDifferentPIDConnected
    /// </summary>
    [WmiClass(Name = "MSFT_NetServiceDifferentPIDConnected")]
    public class MsftNetServiceDifferentPidConnected
    {
        /// <summary>
        /// WMI Property ActualPID
        /// </summary>
        public uint ActualPid { get; set; }

        /// <summary>
        /// WMI Property ExpectedPID
        /// </summary>
        public uint ExpectedPid { get; set; }

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