using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_CCM_RECENTLY_USED_APPS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_CCM_RECENTLY_USED_APPS")]
    public class SmsGSystemCcmRecentlyUsedApps
    {
        /// <summary>
        /// WMI Property AdditionalProductCodes
        /// </summary>
        public string AdditionalProductCodes { get; set; }
        /// <summary>
        /// WMI Property CompanyName
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// WMI Property ExplorerFileName
        /// </summary>
        public string ExplorerFileName { get; set; }
        /// <summary>
        /// WMI Property FileDescription
        /// </summary>
        public string FileDescription { get; set; }
        /// <summary>
        /// WMI Property FilePropertiesHash
        /// </summary>
        public string FilePropertiesHash { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public uint FileSize { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property FolderPath
        /// </summary>
        public string FolderPath { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastUsedTime
        /// </summary>
        public DateTime LastUsedTime { get; set; }
        /// <summary>
        /// WMI Property LastUserName
        /// </summary>
        public string LastUserName { get; set; }
        /// <summary>
        /// WMI Property LaunchCount
        /// </summary>
        public uint LaunchCount { get; set; }
        /// <summary>
        /// WMI Property msiDisplayName
        /// </summary>
        public string MsiDisplayName { get; set; }
        /// <summary>
        /// WMI Property msiPublisher
        /// </summary>
        public string MsiPublisher { get; set; }
        /// <summary>
        /// WMI Property msiVersion
        /// </summary>
        public string MsiVersion { get; set; }
        /// <summary>
        /// WMI Property OriginalFileName
        /// </summary>
        public string OriginalFileName { get; set; }
        /// <summary>
        /// WMI Property ProductCode
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// WMI Property ProductLanguage
        /// </summary>
        public uint ProductLanguage { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SoftwarePropertiesHash
        /// </summary>
        public string SoftwarePropertiesHash { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
