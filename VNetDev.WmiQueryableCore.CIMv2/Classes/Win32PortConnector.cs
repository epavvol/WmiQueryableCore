using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PortConnector
    /// </summary>
    [WmiClass(Name = "Win32_PortConnector")]
    public class Win32PortConnector
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ConnectorPinout
        /// </summary>
        public string ConnectorPinout { get; set; }

        /// <summary>
        /// WMI Property ConnectorType
        /// </summary>
        public ICollection<ushort> ConnectorType { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property ExternalReferenceDesignator
        /// </summary>
        public string ExternalReferenceDesignator { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InternalReferenceDesignator
        /// </summary>
        public string InternalReferenceDesignator { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property OtherIdentifyingInfo
        /// </summary>
        public string OtherIdentifyingInfo { get; set; }

        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// WMI Property PortType
        /// </summary>
        public ushort PortType { get; set; }

        /// <summary>
        /// WMI Property PoweredOn
        /// </summary>
        public bool PoweredOn { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}