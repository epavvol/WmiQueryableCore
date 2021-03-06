using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_History
    /// </summary>
    [WmiClass(Name = "SMS_G_System_History")]
    public class SmsGSystemHistory
    {
        /// <summary>
        /// WMI Property AdminPasswordStatus
        /// </summary>
        public uint AdminPasswordStatus { get; set; }
        /// <summary>
        /// WMI Property AutomaticResetBootOption
        /// </summary>
        public uint AutomaticResetBootOption { get; set; }
        /// <summary>
        /// WMI Property AutomaticResetCapability
        /// </summary>
        public uint AutomaticResetCapability { get; set; }
        /// <summary>
        /// WMI Property BootOptionOnLimit
        /// </summary>
        public uint BootOptionOnLimit { get; set; }
        /// <summary>
        /// WMI Property BootOptionOnWatchDog
        /// </summary>
        public uint BootOptionOnWatchDog { get; set; }
        /// <summary>
        /// WMI Property BootROMSupported
        /// </summary>
        public uint BootRomSupported { get; set; }
        /// <summary>
        /// WMI Property BootupState
        /// </summary>
        public string BootupState { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ChassisBootupState
        /// </summary>
        public uint ChassisBootupState { get; set; }
        /// <summary>
        /// WMI Property CurrentTimeZone
        /// </summary>
        public uint CurrentTimeZone { get; set; }
        /// <summary>
        /// WMI Property DaylightInEffect
        /// </summary>
        public uint DaylightInEffect { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// WMI Property DomainRole
        /// </summary>
        public uint DomainRole { get; set; }
        /// <summary>
        /// WMI Property FrontPanelResetStatus
        /// </summary>
        public uint FrontPanelResetStatus { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InfraredSupported
        /// </summary>
        public uint InfraredSupported { get; set; }
        /// <summary>
        /// WMI Property InitialLoadInfo
        /// </summary>
        public string InitialLoadInfo { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property KeyboardPasswordStatus
        /// </summary>
        public uint KeyboardPasswordStatus { get; set; }
        /// <summary>
        /// WMI Property LastLoadInfo
        /// </summary>
        public string LastLoadInfo { get; set; }
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
        /// WMI Property NameFormat
        /// </summary>
        public string NameFormat { get; set; }
        /// <summary>
        /// WMI Property NetworkServerModeEnabled
        /// </summary>
        public uint NetworkServerModeEnabled { get; set; }
        /// <summary>
        /// WMI Property NumberOfProcessors
        /// </summary>
        public uint NumberOfProcessors { get; set; }
        /// <summary>
        /// WMI Property OEMLogoBitmap
        /// </summary>
        public string OemLogoBitmap { get; set; }
        /// <summary>
        /// WMI Property OEMStringArray
        /// </summary>
        public string OemStringArray { get; set; }
        /// <summary>
        /// WMI Property PauseAfterReset
        /// </summary>
        public string PauseAfterReset { get; set; }
        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
        /// <summary>
        /// WMI Property PowerOnPasswordStatus
        /// </summary>
        public uint PowerOnPasswordStatus { get; set; }
        /// <summary>
        /// WMI Property PowerState
        /// </summary>
        public uint PowerState { get; set; }
        /// <summary>
        /// WMI Property PowerSupplyState
        /// </summary>
        public uint PowerSupplyState { get; set; }
        /// <summary>
        /// WMI Property PrimaryOwnerContact
        /// </summary>
        public string PrimaryOwnerContact { get; set; }
        /// <summary>
        /// WMI Property PrimaryOwnerName
        /// </summary>
        public string PrimaryOwnerName { get; set; }
        /// <summary>
        /// WMI Property ResetCapability
        /// </summary>
        public uint ResetCapability { get; set; }
        /// <summary>
        /// WMI Property ResetCount
        /// </summary>
        public uint ResetCount { get; set; }
        /// <summary>
        /// WMI Property ResetLimit
        /// </summary>
        public uint ResetLimit { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Roles
        /// </summary>
        public string Roles { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property SupportContactDescription
        /// </summary>
        public string SupportContactDescription { get; set; }
        /// <summary>
        /// WMI Property SystemStartupDelay
        /// </summary>
        public uint SystemStartupDelay { get; set; }
        /// <summary>
        /// WMI Property SystemStartupOptions
        /// </summary>
        public string SystemStartupOptions { get; set; }
        /// <summary>
        /// WMI Property SystemStartupSetting
        /// </summary>
        public uint SystemStartupSetting { get; set; }
        /// <summary>
        /// WMI Property SystemType
        /// </summary>
        public string SystemType { get; set; }
        /// <summary>
        /// WMI Property ThermalState
        /// </summary>
        public uint ThermalState { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TotalPhysicalMemory
        /// </summary>
        public ulong TotalPhysicalMemory { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property WakeUpType
        /// </summary>
        public uint WakeUpType { get; set; }
    }
}
