using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_PORTABLE_BATTERY
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_PORTABLE_BATTERY")]
    public class SmsGhSystemPortableBattery
    {
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property BatteryStatus
        /// </summary>
        public uint BatteryStatus { get; set; }
        /// <summary>
        /// WMI Property CapacityMultiplier
        /// </summary>
        public uint CapacityMultiplier { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property Chemistry
        /// </summary>
        public uint Chemistry { get; set; }
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
        /// WMI Property DesignCapacity
        /// </summary>
        public uint DesignCapacity { get; set; }
        /// <summary>
        /// WMI Property DesignVoltage
        /// </summary>
        public string DesignVoltage { get; set; }
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
        /// WMI Property ExpectedLife
        /// </summary>
        public uint ExpectedLife { get; set; }
        /// <summary>
        /// WMI Property FullChargeCapacity
        /// </summary>
        public uint FullChargeCapacity { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
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
        public uint MaxBatteryError { get; set; }
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
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
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
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeOnBattery
        /// </summary>
        public uint TimeOnBattery { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TimeToFullCharge
        /// </summary>
        public uint TimeToFullCharge { get; set; }
    }
}
