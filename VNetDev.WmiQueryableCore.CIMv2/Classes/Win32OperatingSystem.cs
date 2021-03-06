using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OperatingSystem
    /// </summary>
    [WmiClass(Name = "Win32_OperatingSystem")]
    public class Win32OperatingSystem
    {
        /// <summary>
        /// WMI method <c>Reboot</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RebootDelegate();

        /// <summary>
        /// WMI method <c>SetDateTime</c> describing delegate.
        /// <param name="localDateTime">WMI Property <c>LocalDateTime</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDateTimeDelegate(DateTime localDateTime = default);

        /// <summary>
        /// WMI method <c>Shutdown</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ShutdownDelegate();

        /// <summary>
        /// WMI method <c>Win32Shutdown</c> describing delegate.
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>int</c>.</param>
        /// <param name="reserved">WMI Property <c>Reserved</c> of type <c>int</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint Win32ShutdownDelegate(int flags = default, int reserved = default);

        /// <summary>
        /// WMI method <c>Win32ShutdownTracker</c> describing delegate.
        /// <param name="comment">WMI Property <c>Comment</c> of type <c>string</c>.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>int</c>.</param>
        /// <param name="reasonCode">WMI Property <c>ReasonCode</c> of type <c>uint</c>.</param>
        /// <param name="timeout">WMI Property <c>Timeout</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint Win32ShutdownTrackerDelegate(string comment = default, int flags = default,
            uint reasonCode = default, uint timeout = default);

        /// <summary>
        /// WMI method <c>Reboot</c>.
        /// </summary>
        public RebootDelegate Reboot;

        /// <summary>
        /// WMI method <c>SetDateTime</c>.
        /// </summary>
        public SetDateTimeDelegate SetDateTime;

        /// <summary>
        /// WMI method <c>Shutdown</c>.
        /// </summary>
        public ShutdownDelegate Shutdown;

        /// <summary>
        /// WMI method <c>Win32Shutdown</c>.
        /// </summary>
        public Win32ShutdownDelegate Win32Shutdown;

        /// <summary>
        /// WMI method <c>Win32ShutdownTracker</c>.
        /// </summary>
        public Win32ShutdownTrackerDelegate Win32ShutdownTracker;

        /// <summary>
        /// WMI Property BootDevice
        /// </summary>
        public string BootDevice { get; set; }

        /// <summary>
        /// WMI Property BuildNumber
        /// </summary>
        public string BuildNumber { get; set; }

        /// <summary>
        /// WMI Property BuildType
        /// </summary>
        public string BuildType { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CodeSet
        /// </summary>
        public string CodeSet { get; set; }

        /// <summary>
        /// WMI Property CountryCode
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSCreationClassName
        /// </summary>
        public string CsCreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSDVersion
        /// </summary>
        public string CsdVersion { get; set; }

        /// <summary>
        /// WMI Property CSName
        /// </summary>
        public string CsName { get; set; }

        /// <summary>
        /// WMI Property CurrentTimeZone
        /// </summary>
        public short CurrentTimeZone { get; set; }

        /// <summary>
        /// WMI Property DataExecutionPrevention_32BitApplications
        /// </summary>
        [WmiProperty(Name = "DataExecutionPrevention_32BitApplications")]
        public bool DataExecutionPrevention32BitApplications { get; set; }

        /// <summary>
        /// WMI Property DataExecutionPrevention_Available
        /// </summary>
        [WmiProperty(Name = "DataExecutionPrevention_Available")]
        public bool DataExecutionPreventionAvailable { get; set; }

        /// <summary>
        /// WMI Property DataExecutionPrevention_Drivers
        /// </summary>
        [WmiProperty(Name = "DataExecutionPrevention_Drivers")]
        public bool DataExecutionPreventionDrivers { get; set; }

        /// <summary>
        /// WMI Property DataExecutionPrevention_SupportPolicy
        /// </summary>
        [WmiProperty(Name = "DataExecutionPrevention_SupportPolicy")]
        public byte DataExecutionPreventionSupportPolicy { get; set; }

        /// <summary>
        /// WMI Property Debug
        /// </summary>
        public bool Debug { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Distributed
        /// </summary>
        public bool Distributed { get; set; }

        /// <summary>
        /// WMI Property EncryptionLevel
        /// </summary>
        public uint EncryptionLevel { get; set; }

        /// <summary>
        /// WMI Property ForegroundApplicationBoost
        /// </summary>
        public byte ForegroundApplicationBoost { get; set; }

        /// <summary>
        /// WMI Property FreePhysicalMemory
        /// </summary>
        public ulong FreePhysicalMemory { get; set; }

        /// <summary>
        /// WMI Property FreeSpaceInPagingFiles
        /// </summary>
        public ulong FreeSpaceInPagingFiles { get; set; }

        /// <summary>
        /// WMI Property FreeVirtualMemory
        /// </summary>
        public ulong FreeVirtualMemory { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LargeSystemCache
        /// </summary>
        public uint LargeSystemCache { get; set; }

        /// <summary>
        /// WMI Property LastBootUpTime
        /// </summary>
        public DateTime LastBootUpTime { get; set; }

        /// <summary>
        /// WMI Property LocalDateTime
        /// </summary>
        public DateTime LocalDateTime { get; set; }

        /// <summary>
        /// WMI Property Locale
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// WMI Property MaxNumberOfProcesses
        /// </summary>
        public uint MaxNumberOfProcesses { get; set; }

        /// <summary>
        /// WMI Property MaxProcessMemorySize
        /// </summary>
        public ulong MaxProcessMemorySize { get; set; }

        /// <summary>
        /// WMI Property MUILanguages
        /// </summary>
        public ICollection<string> MuiLanguages { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NumberOfLicensedUsers
        /// </summary>
        public uint NumberOfLicensedUsers { get; set; }

        /// <summary>
        /// WMI Property NumberOfProcesses
        /// </summary>
        public uint NumberOfProcesses { get; set; }

        /// <summary>
        /// WMI Property NumberOfUsers
        /// </summary>
        public uint NumberOfUsers { get; set; }

        /// <summary>
        /// WMI Property OperatingSystemSKU
        /// </summary>
        public uint OperatingSystemSku { get; set; }

        /// <summary>
        /// WMI Property Organization
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// WMI Property OSArchitecture
        /// </summary>
        public string OsArchitecture { get; set; }

        /// <summary>
        /// WMI Property OSLanguage
        /// </summary>
        public uint OsLanguage { get; set; }

        /// <summary>
        /// WMI Property OSProductSuite
        /// </summary>
        public uint OsProductSuite { get; set; }

        /// <summary>
        /// WMI Property OSType
        /// </summary>
        public ushort OsType { get; set; }

        /// <summary>
        /// WMI Property OtherTypeDescription
        /// </summary>
        public string OtherTypeDescription { get; set; }

        /// <summary>
        /// WMI Property PAEEnabled
        /// </summary>
        public bool PaeEnabled { get; set; }

        /// <summary>
        /// WMI Property PlusProductID
        /// </summary>
        public string PlusProductId { get; set; }

        /// <summary>
        /// WMI Property PlusVersionNumber
        /// </summary>
        public string PlusVersionNumber { get; set; }

        /// <summary>
        /// WMI Property PortableOperatingSystem
        /// </summary>
        public bool PortableOperatingSystem { get; set; }

        /// <summary>
        /// WMI Property Primary
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// WMI Property ProductType
        /// </summary>
        public uint ProductType { get; set; }

        /// <summary>
        /// WMI Property RegisteredUser
        /// </summary>
        public string RegisteredUser { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// WMI Property ServicePackMajorVersion
        /// </summary>
        public ushort ServicePackMajorVersion { get; set; }

        /// <summary>
        /// WMI Property ServicePackMinorVersion
        /// </summary>
        public ushort ServicePackMinorVersion { get; set; }

        /// <summary>
        /// WMI Property SizeStoredInPagingFiles
        /// </summary>
        public ulong SizeStoredInPagingFiles { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SuiteMask
        /// </summary>
        public uint SuiteMask { get; set; }

        /// <summary>
        /// WMI Property SystemDevice
        /// </summary>
        public string SystemDevice { get; set; }

        /// <summary>
        /// WMI Property SystemDirectory
        /// </summary>
        public string SystemDirectory { get; set; }

        /// <summary>
        /// WMI Property SystemDrive
        /// </summary>
        public string SystemDrive { get; set; }

        /// <summary>
        /// WMI Property TotalSwapSpaceSize
        /// </summary>
        public ulong TotalSwapSpaceSize { get; set; }

        /// <summary>
        /// WMI Property TotalVirtualMemorySize
        /// </summary>
        public ulong TotalVirtualMemorySize { get; set; }

        /// <summary>
        /// WMI Property TotalVisibleMemorySize
        /// </summary>
        public ulong TotalVisibleMemorySize { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// WMI Property WindowsDirectory
        /// </summary>
        public string WindowsDirectory { get; set; }
    }
}