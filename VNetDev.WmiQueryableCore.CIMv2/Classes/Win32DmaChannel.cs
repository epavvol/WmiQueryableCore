using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DMAChannel
    /// </summary>
    [WmiClass(Name = "Win32_DMAChannel")]
    public class Win32DmaChannel
    {
        /// <summary>
        /// WMI Property AddressSize
        /// </summary>
        public ushort AddressSize { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property BurstMode
        /// </summary>
        public bool BurstMode { get; set; }

        /// <summary>
        /// WMI Property ByteMode
        /// </summary>
        public ushort ByteMode { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ChannelTiming
        /// </summary>
        public ushort ChannelTiming { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSCreationClassName
        /// </summary>
        public string CsCreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSName
        /// </summary>
        public string CsName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DMAChannel
        /// </summary>
        public uint DmaChannel { get; set; }

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
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property TransferWidths
        /// </summary>
        public ICollection<ushort> TransferWidths { get; set; }

        /// <summary>
        /// WMI Property TypeCTiming
        /// </summary>
        public ushort TypeCTiming { get; set; }

        /// <summary>
        /// WMI Property WordMode
        /// </summary>
        public ushort WordMode { get; set; }
    }
}