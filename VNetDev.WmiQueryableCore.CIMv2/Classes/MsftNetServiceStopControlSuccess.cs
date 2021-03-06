using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_NetServiceStopControlSuccess
    /// </summary>
    [WmiClass(Name = "MSFT_NetServiceStopControlSuccess")]
    public class MsftNetServiceStopControlSuccess
    {
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// WMI Property Control
        /// </summary>
        public string Control { get; set; }

        /// <summary>
        /// WMI Property Reason
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// WMI Property ReasonText
        /// </summary>
        public string ReasonText { get; set; }

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