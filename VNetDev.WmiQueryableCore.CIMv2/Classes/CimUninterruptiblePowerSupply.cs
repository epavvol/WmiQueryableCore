using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_UninterruptiblePowerSupply
    /// </summary>
    [WmiClass(Name = "CIM_UninterruptiblePowerSupply")]
    public class CimUninterruptiblePowerSupply
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
        /// WMI Property ActiveInputVoltage
        /// </summary>
        public ushort ActiveInputVoltage { get; set; }

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

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
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property IsSwitchingSupply
        /// </summary>
        public bool IsSwitchingSupply { get; set; }

        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }

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
        /// WMI Property Range1InputFrequencyHigh
        /// </summary>
        public uint Range1InputFrequencyHigh { get; set; }

        /// <summary>
        /// WMI Property Range1InputFrequencyLow
        /// </summary>
        public uint Range1InputFrequencyLow { get; set; }

        /// <summary>
        /// WMI Property Range1InputVoltageHigh
        /// </summary>
        public uint Range1InputVoltageHigh { get; set; }

        /// <summary>
        /// WMI Property Range1InputVoltageLow
        /// </summary>
        public uint Range1InputVoltageLow { get; set; }

        /// <summary>
        /// WMI Property Range2InputFrequencyHigh
        /// </summary>
        public uint Range2InputFrequencyHigh { get; set; }

        /// <summary>
        /// WMI Property Range2InputFrequencyLow
        /// </summary>
        public uint Range2InputFrequencyLow { get; set; }

        /// <summary>
        /// WMI Property Range2InputVoltageHigh
        /// </summary>
        public uint Range2InputVoltageHigh { get; set; }

        /// <summary>
        /// WMI Property Range2InputVoltageLow
        /// </summary>
        public uint Range2InputVoltageLow { get; set; }

        /// <summary>
        /// WMI Property RemainingCapacityStatus
        /// </summary>
        public ushort RemainingCapacityStatus { get; set; }

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
        /// WMI Property TimeOnBackup
        /// </summary>
        public uint TimeOnBackup { get; set; }

        /// <summary>
        /// WMI Property TotalOutputPower
        /// </summary>
        public uint TotalOutputPower { get; set; }

        /// <summary>
        /// WMI Property TypeOfRangeSwitching
        /// </summary>
        public ushort TypeOfRangeSwitching { get; set; }
    }
}