using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_WmiConsumerProviderEvent
    /// </summary>
    [WmiClass(Name = "MSFT_WmiConsumerProviderEvent")]
    public class MsftWmiConsumerProviderEvent
    {
        /// <summary>
        /// WMI Property Machine
        /// </summary>
        public string Machine { get; set; }

        /// <summary>
        /// WMI Property Namespace
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }

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