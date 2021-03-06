using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_DMA_CHANNEL
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_DMA_CHANNEL")]
    public class SmsGehSystemDmaChannel
    {
        /// <summary>
        /// WMI Property AddressSize
        /// </summary>
        public uint AddressSize { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property BurstMode
        /// </summary>
        public uint BurstMode { get; set; }
        /// <summary>
        /// WMI Property ByteMode
        /// </summary>
        public uint ByteMode { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ChannelTiming
        /// </summary>
        public uint ChannelTiming { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DMAChannel
        /// </summary>
        public uint DmaChannel { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property MaxTransferSize
        /// </summary>
        public uint MaxTransferSize { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Port
        /// </summary>
        public uint Port { get; set; }
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
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TransferWidths
        /// </summary>
        public string TransferWidths { get; set; }
        /// <summary>
        /// WMI Property TypeCTiming
        /// </summary>
        public uint TypeCTiming { get; set; }
        /// <summary>
        /// WMI Property WordMode
        /// </summary>
        public uint WordMode { get; set; }
    }
}
