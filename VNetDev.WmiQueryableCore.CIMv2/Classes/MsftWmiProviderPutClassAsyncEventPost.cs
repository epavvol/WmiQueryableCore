using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Msft_WmiProvider_PutClassAsyncEvent_Post
    /// </summary>
    [WmiClass(Name = "Msft_WmiProvider_PutClassAsyncEvent_Post")]
    public class MsftWmiProviderPutClassAsyncEventPost
    {
        /// <summary>
        /// WMI Property ClassObject
        /// </summary>
        public object ClassObject { get; set; }

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
        /// WMI Property ObjectParameter
        /// </summary>
        public object ObjectParameter { get; set; }

        /// <summary>
        /// WMI Property provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// WMI Property ResultCode
        /// </summary>
        public uint ResultCode { get; set; }

        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> MsftSecurityDescriptor { get; set; }

        /// <summary>
        /// WMI Property StringParameter
        /// </summary>
        public string StringParameter { get; set; }

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