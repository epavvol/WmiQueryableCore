using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Slot
    /// </summary>
    [WmiClass(Name = "CIM_Slot")]
    public class CimSlot
    {
        /// <summary>
        /// WMI Property BusNumber
        /// </summary>
        public uint BusNumber { get; set; }

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
        /// WMI Property CurrentUsage
        /// </summary>
        public ushort CurrentUsage { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceNumber
        /// </summary>
        public uint DeviceNumber { get; set; }

        /// <summary>
        /// WMI Property FunctionNumber
        /// </summary>
        public uint FunctionNumber { get; set; }

        /// <summary>
        /// WMI Property HeightAllowed
        /// </summary>
        public float HeightAllowed { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LengthAllowed
        /// </summary>
        public float LengthAllowed { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxDataWidth
        /// </summary>
        public ushort MaxDataWidth { get; set; }

        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Number
        /// </summary>
        public ushort Number { get; set; }

        /// <summary>
        /// WMI Property OtherIdentifyingInfo
        /// </summary>
        public string OtherIdentifyingInfo { get; set; }

        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// WMI Property PMESignal
        /// </summary>
        public bool PmeSignal { get; set; }

        /// <summary>
        /// WMI Property PoweredOn
        /// </summary>
        public bool PoweredOn { get; set; }

        /// <summary>
        /// WMI Property PurposeDescription
        /// </summary>
        public string PurposeDescription { get; set; }

        /// <summary>
        /// WMI Property SegmentGroupNumber
        /// </summary>
        public uint SegmentGroupNumber { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property Shared
        /// </summary>
        public bool Shared { get; set; }

        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// WMI Property SlotDesignation
        /// </summary>
        public string SlotDesignation { get; set; }

        /// <summary>
        /// WMI Property SpecialPurpose
        /// </summary>
        public bool SpecialPurpose { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SupportsHotPlug
        /// </summary>
        public bool SupportsHotPlug { get; set; }

        /// <summary>
        /// WMI Property Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// WMI Property ThermalRating
        /// </summary>
        public uint ThermalRating { get; set; }

        /// <summary>
        /// WMI Property VccMixedVoltageSupport
        /// </summary>
        public ICollection<ushort> VccMixedVoltageSupport { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property VppMixedVoltageSupport
        /// </summary>
        public ICollection<ushort> VppMixedVoltageSupport { get; set; }
    }
}