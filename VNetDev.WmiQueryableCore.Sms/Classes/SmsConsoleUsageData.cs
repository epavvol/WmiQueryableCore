using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConsoleUsageData
    /// </summary>
    [WmiClass(Name = "SMS_ConsoleUsageData")]
    public class SmsConsoleUsageData
    {
        /// <summary>
        /// WMI Property CMClientVersion
        /// </summary>
        public string CmClientVersion { get; set; }
        /// <summary>
        /// WMI Property CMConsoleInstalledLangPacks
        /// </summary>
        public string CmConsoleInstalledLangPacks { get; set; }
        /// <summary>
        /// WMI Property CMConsoleScreenResolution
        /// </summary>
        public string CmConsoleScreenResolution { get; set; }
        /// <summary>
        /// WMI Property ConsoleConnectTime
        /// </summary>
        public DateTime ConsoleConnectTime { get; set; }
        /// <summary>
        /// WMI Property ConsoleVersion
        /// </summary>
        public string ConsoleVersion { get; set; }
        /// <summary>
        /// WMI Property ExtensionInfo
        /// </summary>
        public string ExtensionInfo { get; set; }
        /// <summary>
        /// WMI Property Locale
        /// </summary>
        public string Locale { get; set; }
        /// <summary>
        /// WMI Property MUILanguages
        /// </summary>
        public string MuiLanguages { get; set; }
        /// <summary>
        /// WMI Property NetFx40InstallationStatus
        /// </summary>
        public uint NetFx40InstallationStatus { get; set; }
        /// <summary>
        /// WMI Property NetFx45ReleaseVersion
        /// </summary>
        public uint NetFx45ReleaseVersion { get; set; }
        /// <summary>
        /// WMI Property NumberOfActionExtensions
        /// </summary>
        public uint NumberOfActionExtensions { get; set; }
        /// <summary>
        /// WMI Property NumberOfFormExtensions
        /// </summary>
        public uint NumberOfFormExtensions { get; set; }
        /// <summary>
        /// WMI Property NumberOfLogicalProcessors
        /// </summary>
        public uint NumberOfLogicalProcessors { get; set; }
        /// <summary>
        /// WMI Property NumberOfManagementClassExtensions
        /// </summary>
        public uint NumberOfManagementClassExtensions { get; set; }
        /// <summary>
        /// WMI Property NumberOfNodeExtensions
        /// </summary>
        public uint NumberOfNodeExtensions { get; set; }
        /// <summary>
        /// WMI Property NumberOfProcessors
        /// </summary>
        public uint NumberOfProcessors { get; set; }
        /// <summary>
        /// WMI Property OperatingSystemSKU
        /// </summary>
        public uint OperatingSystemSku { get; set; }
        /// <summary>
        /// WMI Property OSArchitecture
        /// </summary>
        public string OsArchitecture { get; set; }
        /// <summary>
        /// WMI Property OSBuildNumber
        /// </summary>
        public uint OsBuildNumber { get; set; }
        /// <summary>
        /// WMI Property OSLanguage
        /// </summary>
        public uint OsLanguage { get; set; }
        /// <summary>
        /// WMI Property OSMajorVersion
        /// </summary>
        public uint OsMajorVersion { get; set; }
        /// <summary>
        /// WMI Property OSMinorVersion
        /// </summary>
        public uint OsMinorVersion { get; set; }
        /// <summary>
        /// WMI Property OSProductSuite
        /// </summary>
        public uint OsProductSuite { get; set; }
        /// <summary>
        /// WMI Property OSType
        /// </summary>
        public uint OsType { get; set; }
        /// <summary>
        /// WMI Property OutOfBoxExtendedForms
        /// </summary>
        public string OutOfBoxExtendedForms { get; set; }
        /// <summary>
        /// WMI Property ProcessName
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        /// WMI Property TotalPhysicalMemory
        /// </summary>
        public ulong TotalPhysicalMemory { get; set; }
    }
}
