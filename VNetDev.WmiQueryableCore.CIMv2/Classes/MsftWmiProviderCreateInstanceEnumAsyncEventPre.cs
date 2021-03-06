using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre
    /// </summary>
    [WmiClass(Name = "Msft_WmiProvider_CreateInstanceEnumAsyncEvent_Pre")]
    public class MsftWmiProviderCreateInstanceEnumAsyncEventPre
    {
        /// <summary>
        /// WMI Property ClassName
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }

        /// <summary>
        /// WMI Property HostingGroup
        /// </summary>
        public string HostingGroup { get; set; }

        /// <summary>
        /// WMI Property HostingSpecification
        /// </summary>
        public uint HostingSpecification { get; set; }

        /// <summary>
        /// WMI Property Locale
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// WMI Property Namespace
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// WMI Property provider
        /// </summary>
        public string Provider { get; set; }

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

        /// <summary>
        /// WMI Property TransactionIdentifer
        /// </summary>
        public string TransactionIdentifer { get; set; }

        /// <summary>
        /// WMI Property User
        /// </summary>
        public string User { get; set; }
    }
}