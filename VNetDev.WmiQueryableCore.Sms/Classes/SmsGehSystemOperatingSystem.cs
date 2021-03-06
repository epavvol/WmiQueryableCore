using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_OPERATING_SYSTEM
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_OPERATING_SYSTEM")]
    public class SmsGehSystemOperatingSystem
    {
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
        /// WMI Property CSDVersion
        /// </summary>
        public string CsdVersion { get; set; }
        /// <summary>
        /// WMI Property CurrentTimeZone
        /// </summary>
        public uint CurrentTimeZone { get; set; }
        /// <summary>
        /// WMI Property Debug
        /// </summary>
        public uint Debug { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Distributed
        /// </summary>
        public uint Distributed { get; set; }
        /// <summary>
        /// WMI Property ForegroundApplicationBoost
        /// </summary>
        public uint ForegroundApplicationBoost { get; set; }
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
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
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
        public string MuiLanguages { get; set; }
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
        public uint OsType { get; set; }
        /// <summary>
        /// WMI Property OtherTypeDescription
        /// </summary>
        public string OtherTypeDescription { get; set; }
        /// <summary>
        /// WMI Property PlusProductID
        /// </summary>
        public string PlusProductId { get; set; }
        /// <summary>
        /// WMI Property PlusVersionNumber
        /// </summary>
        public string PlusVersionNumber { get; set; }
        /// <summary>
        /// WMI Property Primary
        /// </summary>
        public uint Primary { get; set; }
        /// <summary>
        /// WMI Property ProductType
        /// </summary>
        public uint ProductType { get; set; }
        /// <summary>
        /// WMI Property RegisteredUser
        /// </summary>
        public string RegisteredUser { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property ServicePackMajorVersion
        /// </summary>
        public uint ServicePackMajorVersion { get; set; }
        /// <summary>
        /// WMI Property ServicePackMinorVersion
        /// </summary>
        public uint ServicePackMinorVersion { get; set; }
        /// <summary>
        /// WMI Property SizeStoredInPagingFiles
        /// </summary>
        public ulong SizeStoredInPagingFiles { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property SystemDevice
        /// </summary>
        public string SystemDevice { get; set; }
        /// <summary>
        /// WMI Property SystemDirectory
        /// </summary>
        public string SystemDirectory { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
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
