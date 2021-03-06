using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_UnitaryComputerSystem
    /// </summary>
    [WmiClass(Name = "CIM_UnitaryComputerSystem")]
    public class CimUnitaryComputerSystem
    {
        /// <summary>
        /// WMI method <c>JoinDomainOrWorkgroup</c> describing delegate.
        /// <param name="accountOu">WMI Property <c>AccountOU</c> of type <c>string</c>.</param>
        /// <param name="fJoinOptions">WMI Property <c>FJoinOptions</c> of type <c>uint</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint JoinDomainOrWorkgroupDelegate(string accountOu = default, uint fJoinOptions = default,
            string name = default, string password = default, string userName = default);

        /// <summary>
        /// WMI method <c>Rename</c> describing delegate.
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenameDelegate(string name = default, string password = default,
            string userName = default);

        /// <summary>
        /// WMI method <c>SetPowerState</c> describing delegate.
        /// <param name="powerState">WMI Property <c>PowerState</c> of type <c>ushort</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPowerStateDelegate(ushort powerState = default, DateTime time = default);

        /// <summary>
        /// WMI method <c>UnjoinDomainOrWorkgroup</c> describing delegate.
        /// <param name="fUnjoinOptions">WMI Property <c>FUnjoinOptions</c> of type <c>uint</c>.</param>
        /// <param name="password">WMI Property <c>Password</c> of type <c>string</c>.</param>
        /// <param name="userName">WMI Property <c>UserName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint UnjoinDomainOrWorkgroupDelegate(uint fUnjoinOptions = default, string password = default,
            string userName = default);

        /// <summary>
        /// WMI method <c>JoinDomainOrWorkgroup</c>.
        /// </summary>
        public JoinDomainOrWorkgroupDelegate JoinDomainOrWorkgroup;

        /// <summary>
        /// WMI method <c>Rename</c>.
        /// </summary>
        public RenameDelegate Rename;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI method <c>UnjoinDomainOrWorkgroup</c>.
        /// </summary>
        public UnjoinDomainOrWorkgroupDelegate UnjoinDomainOrWorkgroup;

        /// <summary>
        /// WMI Property AdminPasswordStatus
        /// </summary>
        public ushort AdminPasswordStatus { get; set; }

        /// <summary>
        /// WMI Property AutomaticManagedPagefile
        /// </summary>
        public bool AutomaticManagedPagefile { get; set; }

        /// <summary>
        /// WMI Property AutomaticResetBootOption
        /// </summary>
        public bool AutomaticResetBootOption { get; set; }

        /// <summary>
        /// WMI Property AutomaticResetCapability
        /// </summary>
        public bool AutomaticResetCapability { get; set; }

        /// <summary>
        /// WMI Property BootOptionOnLimit
        /// </summary>
        public ushort BootOptionOnLimit { get; set; }

        /// <summary>
        /// WMI Property BootOptionOnWatchDog
        /// </summary>
        public ushort BootOptionOnWatchDog { get; set; }

        /// <summary>
        /// WMI Property BootROMSupported
        /// </summary>
        public bool BootRomSupported { get; set; }

        /// <summary>
        /// WMI Property BootStatus
        /// </summary>
        public ICollection<ushort> BootStatus { get; set; }

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
        public ushort ChassisBootupState { get; set; }

        /// <summary>
        /// WMI Property ChassisSKUNumber
        /// </summary>
        public string ChassisSkuNumber { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CurrentTimeZone
        /// </summary>
        public short CurrentTimeZone { get; set; }

        /// <summary>
        /// WMI Property DaylightInEffect
        /// </summary>
        public bool DaylightInEffect { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DNSHostName
        /// </summary>
        public string DnsHostName { get; set; }

        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// WMI Property DomainRole
        /// </summary>
        public ushort DomainRole { get; set; }

        /// <summary>
        /// WMI Property EnableDaylightSavingsTime
        /// </summary>
        public bool EnableDaylightSavingsTime { get; set; }

        /// <summary>
        /// WMI Property FrontPanelResetStatus
        /// </summary>
        public ushort FrontPanelResetStatus { get; set; }

        /// <summary>
        /// WMI Property HypervisorPresent
        /// </summary>
        public bool HypervisorPresent { get; set; }

        /// <summary>
        /// WMI Property InfraredSupported
        /// </summary>
        public bool InfraredSupported { get; set; }

        /// <summary>
        /// WMI Property InitialLoadInfo
        /// </summary>
        public ICollection<string> InitialLoadInfo { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property KeyboardPasswordStatus
        /// </summary>
        public ushort KeyboardPasswordStatus { get; set; }

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
        public bool NetworkServerModeEnabled { get; set; }

        /// <summary>
        /// WMI Property NumberOfLogicalProcessors
        /// </summary>
        public uint NumberOfLogicalProcessors { get; set; }

        /// <summary>
        /// WMI Property NumberOfProcessors
        /// </summary>
        public uint NumberOfProcessors { get; set; }

        /// <summary>
        /// WMI Property OEMLogoBitmap
        /// </summary>
        public ICollection<byte> OemLogoBitmap { get; set; }

        /// <summary>
        /// WMI Property OEMStringArray
        /// </summary>
        public ICollection<string> OemStringArray { get; set; }

        /// <summary>
        /// WMI Property PartOfDomain
        /// </summary>
        public bool PartOfDomain { get; set; }

        /// <summary>
        /// WMI Property PauseAfterReset
        /// </summary>
        public long PauseAfterReset { get; set; }

        /// <summary>
        /// WMI Property PCSystemType
        /// </summary>
        public ushort PcSystemType { get; set; }

        /// <summary>
        /// WMI Property PCSystemTypeEx
        /// </summary>
        public ushort PcSystemTypeEx { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property PowerOnPasswordStatus
        /// </summary>
        public ushort PowerOnPasswordStatus { get; set; }

        /// <summary>
        /// WMI Property PowerState
        /// </summary>
        public ushort PowerState { get; set; }

        /// <summary>
        /// WMI Property PowerSupplyState
        /// </summary>
        public ushort PowerSupplyState { get; set; }

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
        public ushort ResetCapability { get; set; }

        /// <summary>
        /// WMI Property ResetCount
        /// </summary>
        public short ResetCount { get; set; }

        /// <summary>
        /// WMI Property ResetLimit
        /// </summary>
        public short ResetLimit { get; set; }

        /// <summary>
        /// WMI Property Roles
        /// </summary>
        public ICollection<string> Roles { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SupportContactDescription
        /// </summary>
        public ICollection<string> SupportContactDescription { get; set; }

        /// <summary>
        /// WMI Property SystemFamily
        /// </summary>
        public string SystemFamily { get; set; }

        /// <summary>
        /// WMI Property SystemSKUNumber
        /// </summary>
        public string SystemSkuNumber { get; set; }

        /// <summary>
        /// WMI Property SystemStartupDelay
        /// </summary>
        public ushort SystemStartupDelay { get; set; }

        /// <summary>
        /// WMI Property SystemStartupOptions
        /// </summary>
        public ICollection<string> SystemStartupOptions { get; set; }

        /// <summary>
        /// WMI Property SystemStartupSetting
        /// </summary>
        public byte SystemStartupSetting { get; set; }

        /// <summary>
        /// WMI Property SystemType
        /// </summary>
        public string SystemType { get; set; }

        /// <summary>
        /// WMI Property ThermalState
        /// </summary>
        public ushort ThermalState { get; set; }

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
        public ushort WakeUpType { get; set; }

        /// <summary>
        /// WMI Property Workgroup
        /// </summary>
        public string Workgroup { get; set; }
    }
}