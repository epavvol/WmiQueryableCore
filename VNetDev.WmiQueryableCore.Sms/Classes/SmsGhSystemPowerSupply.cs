using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_POWER_SUPPLY
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_POWER_SUPPLY")]
    public class SmsGhSystemPowerSupply
    {
        /// <summary>
        /// WMI Property ActiveInputVoltage
        /// </summary>
        public uint ActiveInputVoltage { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property BatteryInstalled
        /// </summary>
        public uint BatteryInstalled { get; set; }
        /// <summary>
        /// WMI Property CanTurnOffRemotely
        /// </summary>
        public uint CanTurnOffRemotely { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property CommandFile
        /// </summary>
        public string CommandFile { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public uint ConfigManagerUserConfig { get; set; }
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
        public uint ErrorCleared { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property EstimatedChargeRemaining
        /// </summary>
        public uint EstimatedChargeRemaining { get; set; }
        /// <summary>
        /// WMI Property EstimatedRunTime
        /// </summary>
        public uint EstimatedRunTime { get; set; }
        /// <summary>
        /// WMI Property FirstMessageDelay
        /// </summary>
        public uint FirstMessageDelay { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property IsSwitchingSupply
        /// </summary>
        public uint IsSwitchingSupply { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property LowBatterySignal
        /// </summary>
        public uint LowBatterySignal { get; set; }
        /// <summary>
        /// WMI Property MessageInterval
        /// </summary>
        public uint MessageInterval { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }
        /// <summary>
        /// WMI Property PowerFailSignal
        /// </summary>
        public uint PowerFailSignal { get; set; }
        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
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
        public uint RemainingCapacityStatus { get; set; }
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
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeOnBackup
        /// </summary>
        public uint TimeOnBackup { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TotalOutputPower
        /// </summary>
        public uint TotalOutputPower { get; set; }
        /// <summary>
        /// WMI Property TypeOfRangeSwitching
        /// </summary>
        public uint TypeOfRangeSwitching { get; set; }
        /// <summary>
        /// WMI Property UPSPort
        /// </summary>
        public string UpsPort { get; set; }
    }
}
