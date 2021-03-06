using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PhysicalMemory
    /// </summary>
    [WmiClass(Name = "Win32_PhysicalMemory")]
    public class Win32PhysicalMemory
    {
        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public uint Attributes { get; set; }

        /// <summary>
        /// WMI Property BankLabel
        /// </summary>
        public string BankLabel { get; set; }

        /// <summary>
        /// WMI Property Capacity
        /// </summary>
        public ulong Capacity { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ConfiguredClockSpeed
        /// </summary>
        public uint ConfiguredClockSpeed { get; set; }

        /// <summary>
        /// WMI Property ConfiguredVoltage
        /// </summary>
        public uint ConfiguredVoltage { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property DataWidth
        /// </summary>
        public ushort DataWidth { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceLocator
        /// </summary>
        public string DeviceLocator { get; set; }

        /// <summary>
        /// WMI Property FormFactor
        /// </summary>
        public ushort FormFactor { get; set; }

        /// <summary>
        /// WMI Property HotSwappable
        /// </summary>
        public bool HotSwappable { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InterleaveDataDepth
        /// </summary>
        public ushort InterleaveDataDepth { get; set; }

        /// <summary>
        /// WMI Property InterleavePosition
        /// </summary>
        public uint InterleavePosition { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxVoltage
        /// </summary>
        public uint MaxVoltage { get; set; }

        /// <summary>
        /// WMI Property MemoryType
        /// </summary>
        public ushort MemoryType { get; set; }

        /// <summary>
        /// WMI Property MinVoltage
        /// </summary>
        public uint MinVoltage { get; set; }

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
        /// WMI Property PositionInRow
        /// </summary>
        public uint PositionInRow { get; set; }

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
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// WMI Property SMBIOSMemoryType
        /// </summary>
        public uint SmbiosMemoryType { get; set; }

        /// <summary>
        /// WMI Property Speed
        /// </summary>
        public uint Speed { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// WMI Property TotalWidth
        /// </summary>
        public ushort TotalWidth { get; set; }

        /// <summary>
        /// WMI Property TypeDetail
        /// </summary>
        public ushort TypeDetail { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}