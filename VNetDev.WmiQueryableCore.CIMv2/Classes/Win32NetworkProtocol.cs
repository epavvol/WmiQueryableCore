using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NetworkProtocol
    /// </summary>
    [WmiClass(Name = "Win32_NetworkProtocol")]
    public class Win32NetworkProtocol
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ConnectionlessService
        /// </summary>
        public bool ConnectionlessService { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property GuaranteesDelivery
        /// </summary>
        public bool GuaranteesDelivery { get; set; }

        /// <summary>
        /// WMI Property GuaranteesSequencing
        /// </summary>
        public bool GuaranteesSequencing { get; set; }

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
        public bool MessageOriented { get; set; }

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
        public bool PseudoStreamOriented { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SupportsBroadcasting
        /// </summary>
        public bool SupportsBroadcasting { get; set; }

        /// <summary>
        /// WMI Property SupportsConnectData
        /// </summary>
        public bool SupportsConnectData { get; set; }

        /// <summary>
        /// WMI Property SupportsDisconnectData
        /// </summary>
        public bool SupportsDisconnectData { get; set; }

        /// <summary>
        /// WMI Property SupportsEncryption
        /// </summary>
        public bool SupportsEncryption { get; set; }

        /// <summary>
        /// WMI Property SupportsExpeditedData
        /// </summary>
        public bool SupportsExpeditedData { get; set; }

        /// <summary>
        /// WMI Property SupportsFragmentation
        /// </summary>
        public bool SupportsFragmentation { get; set; }

        /// <summary>
        /// WMI Property SupportsGracefulClosing
        /// </summary>
        public bool SupportsGracefulClosing { get; set; }

        /// <summary>
        /// WMI Property SupportsGuaranteedBandwidth
        /// </summary>
        public bool SupportsGuaranteedBandwidth { get; set; }

        /// <summary>
        /// WMI Property SupportsMulticasting
        /// </summary>
        public bool SupportsMulticasting { get; set; }

        /// <summary>
        /// WMI Property SupportsQualityofService
        /// </summary>
        public bool SupportsQualityofService { get; set; }
    }
}