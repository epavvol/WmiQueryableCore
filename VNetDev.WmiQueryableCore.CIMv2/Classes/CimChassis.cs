using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Chassis
    /// </summary>
    [WmiClass(Name = "CIM_Chassis")]
    public class CimChassis
    {
        /// <summary>
        /// WMI method <c>IsCompatible</c> describing delegate.
        /// <param name="elementToCheck">WMI Property <c>ElementToCheck</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint IsCompatibleDelegate(object elementToCheck = default);

        /// <summary>
        /// WMI method <c>IsCompatible</c>.
        /// </summary>
        public IsCompatibleDelegate IsCompatible;

        /// <summary>
        /// WMI Property AudibleAlarm
        /// </summary>
        public bool AudibleAlarm { get; set; }

        /// <summary>
        /// WMI Property BreachDescription
        /// </summary>
        public string BreachDescription { get; set; }

        /// <summary>
        /// WMI Property CableManagementStrategy
        /// </summary>
        public string CableManagementStrategy { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ChassisTypes
        /// </summary>
        public ICollection<ushort> ChassisTypes { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CurrentRequiredOrProduced
        /// </summary>
        public short CurrentRequiredOrProduced { get; set; }

        /// <summary>
        /// WMI Property Depth
        /// </summary>
        public float Depth { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property HeatGeneration
        /// </summary>
        public ushort HeatGeneration { get; set; }

        /// <summary>
        /// WMI Property Height
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// WMI Property HotSwappable
        /// </summary>
        public bool HotSwappable { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LockPresent
        /// </summary>
        public bool LockPresent { get; set; }

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
        /// WMI Property NumberOfPowerCords
        /// </summary>
        public ushort NumberOfPowerCords { get; set; }

        /// <summary>
        /// WMI Property OtherIdentifyingInfo
        /// </summary>
        public string OtherIdentifyingInfo { get; set; }

        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// WMI Property PoweredOn
        /// </summary>
        public bool PoweredOn { get; set; }

        /// <summary>
        /// WMI Property Removable
        /// </summary>
        public bool Removable { get; set; }

        /// <summary>
        /// WMI Property Replaceable
        /// </summary>
        public bool Replaceable { get; set; }

        /// <summary>
        /// WMI Property SecurityBreach
        /// </summary>
        public ushort SecurityBreach { get; set; }

        /// <summary>
        /// WMI Property SecurityStatus
        /// </summary>
        public ushort SecurityStatus { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property ServiceDescriptions
        /// </summary>
        public ICollection<string> ServiceDescriptions { get; set; }

        /// <summary>
        /// WMI Property ServicePhilosophy
        /// </summary>
        public ICollection<ushort> ServicePhilosophy { get; set; }

        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// WMI Property SMBIOSAssetTag
        /// </summary>
        public string SmbiosAssetTag { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// WMI Property TypeDescriptions
        /// </summary>
        public ICollection<string> TypeDescriptions { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property VisibleAlarm
        /// </summary>
        public bool VisibleAlarm { get; set; }

        /// <summary>
        /// WMI Property Weight
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// WMI Property Width
        /// </summary>
        public float Width { get; set; }
    }
}