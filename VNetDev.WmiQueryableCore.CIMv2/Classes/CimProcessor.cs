using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Processor
    /// </summary>
    [WmiClass(Name = "CIM_Processor")]
    public class CimProcessor
    {
        /// <summary>
        /// WMI method <c>Reset</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetDelegate();

        /// <summary>
        /// WMI method <c>SetPowerState</c> describing delegate.
        /// <param name="powerState">WMI Property <c>PowerState</c> of type <c>ushort</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPowerStateDelegate(ushort powerState = default, DateTime time = default);

        /// <summary>
        /// WMI method <c>Reset</c>.
        /// </summary>
        public ResetDelegate Reset;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI Property AddressWidth
        /// </summary>
        public ushort AddressWidth { get; set; }

        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public ushort Architecture { get; set; }

        /// <summary>
        /// WMI Property AssetTag
        /// </summary>
        public string AssetTag { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Characteristics
        /// </summary>
        public uint Characteristics { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property CpuStatus
        /// </summary>
        public ushort CpuStatus { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CurrentClockSpeed
        /// </summary>
        public uint CurrentClockSpeed { get; set; }

        /// <summary>
        /// WMI Property CurrentVoltage
        /// </summary>
        public ushort CurrentVoltage { get; set; }

        /// <summary>
        /// WMI Property DataWidth
        /// </summary>
        public ushort DataWidth { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property ExtClock
        /// </summary>
        public uint ExtClock { get; set; }

        /// <summary>
        /// WMI Property Family
        /// </summary>
        public ushort Family { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property L2CacheSize
        /// </summary>
        public uint L2CacheSize { get; set; }

        /// <summary>
        /// WMI Property L2CacheSpeed
        /// </summary>
        public uint L2CacheSpeed { get; set; }

        /// <summary>
        /// WMI Property L3CacheSize
        /// </summary>
        public uint L3CacheSize { get; set; }

        /// <summary>
        /// WMI Property L3CacheSpeed
        /// </summary>
        public uint L3CacheSpeed { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property Level
        /// </summary>
        public ushort Level { get; set; }

        /// <summary>
        /// WMI Property LoadPercentage
        /// </summary>
        public ushort LoadPercentage { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxClockSpeed
        /// </summary>
        public uint MaxClockSpeed { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NumberOfCores
        /// </summary>
        public uint NumberOfCores { get; set; }

        /// <summary>
        /// WMI Property NumberOfEnabledCore
        /// </summary>
        public uint NumberOfEnabledCore { get; set; }

        /// <summary>
        /// WMI Property NumberOfLogicalProcessors
        /// </summary>
        public uint NumberOfLogicalProcessors { get; set; }

        /// <summary>
        /// WMI Property OtherFamilyDescription
        /// </summary>
        public string OtherFamilyDescription { get; set; }

        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property ProcessorId
        /// </summary>
        public string ProcessorId { get; set; }

        /// <summary>
        /// WMI Property ProcessorType
        /// </summary>
        public ushort ProcessorType { get; set; }

        /// <summary>
        /// WMI Property Revision
        /// </summary>
        public ushort Revision { get; set; }

        /// <summary>
        /// WMI Property Role
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// WMI Property SecondLevelAddressTranslationExtensions
        /// </summary>
        public bool SecondLevelAddressTranslationExtensions { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property SocketDesignation
        /// </summary>
        public string SocketDesignation { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property Stepping
        /// </summary>
        public string Stepping { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property ThreadCount
        /// </summary>
        public uint ThreadCount { get; set; }

        /// <summary>
        /// WMI Property UniqueId
        /// </summary>
        public string UniqueId { get; set; }

        /// <summary>
        /// WMI Property UpgradeMethod
        /// </summary>
        public ushort UpgradeMethod { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property VirtualizationFirmwareEnabled
        /// </summary>
        public bool VirtualizationFirmwareEnabled { get; set; }

        /// <summary>
        /// WMI Property VMMonitorModeExtensions
        /// </summary>
        public bool VmMonitorModeExtensions { get; set; }

        /// <summary>
        /// WMI Property VoltageCaps
        /// </summary>
        public uint VoltageCaps { get; set; }
    }
}