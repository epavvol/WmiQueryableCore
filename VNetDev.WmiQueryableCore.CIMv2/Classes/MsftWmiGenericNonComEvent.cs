using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_WMI_GenericNonCOMEvent
    /// </summary>
    [WmiClass(Name = "MSFT_WMI_GenericNonCOMEvent")]
    public class MsftWmiGenericNonComEvent
    {
        /// <summary>
        /// WMI Property ProcessId
        /// </summary>
        public uint ProcessId { get; set; }

        /// <summary>
        /// WMI Property PropertyNames
        /// </summary>
        public ICollection<string> PropertyNames { get; set; }

        /// <summary>
        /// WMI Property PropertyValues
        /// </summary>
        public ICollection<string> PropertyValues { get; set; }

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