using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PortableBattery
    /// </summary>
    [WmiClass(Name = "Win32_PortableBattery")]
    public class Win32PortableBattery
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
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property BatteryStatus
        /// </summary>
        public ushort BatteryStatus { get; set; }

        /// <summary>
        /// WMI Property CapacityMultiplier
        /// </summary>
        public ushort CapacityMultiplier { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Chemistry
        /// </summary>
        public ushort Chemistry { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }

        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DesignCapacity
        /// </summary>
        public uint DesignCapacity { get; set; }

        /// <summary>
        /// WMI Property DesignVoltage
        /// </summary>
        public ulong DesignVoltage { get; set; }

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
        /// WMI Property EstimatedChargeRemaining
        /// </summary>
        public ushort EstimatedChargeRemaining { get; set; }

        /// <summary>
        /// WMI Property EstimatedRunTime
        /// </summary>
        public uint EstimatedRunTime { get; set; }

        /// <summary>
        /// WMI Property ExpectedLife
        /// </summary>
        public uint ExpectedLife { get; set; }

        /// <summary>
        /// WMI Property FullChargeCapacity
        /// </summary>
        public uint FullChargeCapacity { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// WMI Property ManufactureDate
        /// </summary>
        public string ManufactureDate { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxBatteryError
        /// </summary>
        public ushort MaxBatteryError { get; set; }

        /// <summary>
        /// WMI Property MaxRechargeTime
        /// </summary>
        public uint MaxRechargeTime { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

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
        /// WMI Property SmartBatteryVersion
        /// </summary>
        public string SmartBatteryVersion { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property TimeOnBattery
        /// </summary>
        public uint TimeOnBattery { get; set; }

        /// <summary>
        /// WMI Property TimeToFullCharge
        /// </summary>
        public uint TimeToFullCharge { get; set; }
    }
}