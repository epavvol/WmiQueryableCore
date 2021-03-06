using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_INSTALLED_SOFTWARE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_INSTALLED_SOFTWARE")]
    public class SmsGSystemInstalledSoftware
    {
        /// <summary>
        /// WMI Property ARPDisplayName
        /// </summary>
        public string ArpDisplayName { get; set; }
        /// <summary>
        /// WMI Property ChannelCode
        /// </summary>
        public string ChannelCode { get; set; }
        /// <summary>
        /// WMI Property ChannelID
        /// </summary>
        public string ChannelId { get; set; }
        /// <summary>
        /// WMI Property CM_DSLID
        /// </summary>
        [WmiProperty(Name = "CM_DSLID")]
        public string CmDslid { get; set; }
        /// <summary>
        /// WMI Property EvidenceSource
        /// </summary>
        public string EvidenceSource { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property InstallDirectoryValidation
        /// </summary>
        public uint InstallDirectoryValidation { get; set; }
        /// <summary>
        /// WMI Property InstalledLocation
        /// </summary>
        public string InstalledLocation { get; set; }
        /// <summary>
        /// WMI Property InstallSource
        /// </summary>
        public string InstallSource { get; set; }
        /// <summary>
        /// WMI Property InstallType
        /// </summary>
        public uint InstallType { get; set; }
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public uint Language { get; set; }
        /// <summary>
        /// WMI Property LocalPackage
        /// </summary>
        public string LocalPackage { get; set; }
        /// <summary>
        /// WMI Property MPC
        /// </summary>
        public string Mpc { get; set; }
        /// <summary>
        /// WMI Property OsComponent
        /// </summary>
        public uint OsComponent { get; set; }
        /// <summary>
        /// WMI Property PackageCode
        /// </summary>
        public string PackageCode { get; set; }
        /// <summary>
        /// WMI Property ProductID
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
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
        /// WMI Property ServicePack
        /// </summary>
        public string ServicePack { get; set; }
        /// <summary>
        /// WMI Property SoftwareCode
        /// </summary>
        public string SoftwareCode { get; set; }
        /// <summary>
        /// WMI Property SoftwarePropertiesHash
        /// </summary>
        public string SoftwarePropertiesHash { get; set; }
        /// <summary>
        /// WMI Property SoftwarePropertiesHashEx
        /// </summary>
        public string SoftwarePropertiesHashEx { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UninstallString
        /// </summary>
        public string UninstallString { get; set; }
        /// <summary>
        /// WMI Property UpgradeCode
        /// </summary>
        public string UpgradeCode { get; set; }
        /// <summary>
        /// WMI Property VersionMajor
        /// </summary>
        public uint VersionMajor { get; set; }
        /// <summary>
        /// WMI Property VersionMinor
        /// </summary>
        public uint VersionMinor { get; set; }
    }
}
