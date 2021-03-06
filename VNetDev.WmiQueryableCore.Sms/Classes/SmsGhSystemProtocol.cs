using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_PROTOCOL
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_PROTOCOL")]
    public class SmsGhSystemProtocol
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ConnectionlessService
        /// </summary>
        public uint ConnectionlessService { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property GuaranteesDelivery
        /// </summary>
        public uint GuaranteesDelivery { get; set; }
        /// <summary>
        /// WMI Property GuaranteesSequencing
        /// </summary>
        public uint GuaranteesSequencing { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property MaximumAddressSize
        /// </summary>
        public uint MaximumAddressSize { get; set; }
        /// <summary>
        /// WMI Property MaximumMessageSize
        /// </summary>
        public uint MaximumMessageSize { get; set; }
        /// <summary>
        /// WMI Property MessageOriented
        /// </summary>
        public uint MessageOriented { get; set; }
        /// <summary>
        /// WMI Property MinimumAddressSize
        /// </summary>
        public uint MinimumAddressSize { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PseudoStreamOriented
        /// </summary>
        public uint PseudoStreamOriented { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property SupportsBroadcasting
        /// </summary>
        public uint SupportsBroadcasting { get; set; }
        /// <summary>
        /// WMI Property SupportsConnectData
        /// </summary>
        public uint SupportsConnectData { get; set; }
        /// <summary>
        /// WMI Property SupportsDisconnectData
        /// </summary>
        public uint SupportsDisconnectData { get; set; }
        /// <summary>
        /// WMI Property SupportsEncryption
        /// </summary>
        public uint SupportsEncryption { get; set; }
        /// <summary>
        /// WMI Property SupportsExpeditedData
        /// </summary>
        public uint SupportsExpeditedData { get; set; }
        /// <summary>
        /// WMI Property SupportsFragmentation
        /// </summary>
        public uint SupportsFragmentation { get; set; }
        /// <summary>
        /// WMI Property SupportsGracefulClosing
        /// </summary>
        public uint SupportsGracefulClosing { get; set; }
        /// <summary>
        /// WMI Property SupportsGuaranteedBandwidth
        /// </summary>
        public uint SupportsGuaranteedBandwidth { get; set; }
        /// <summary>
        /// WMI Property SupportsMulticasting
        /// </summary>
        public uint SupportsMulticasting { get; set; }
        /// <summary>
        /// WMI Property SupportsQualityofService
        /// </summary>
        public uint SupportsQualityofService { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
