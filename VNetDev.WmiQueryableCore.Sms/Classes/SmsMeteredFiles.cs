using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MeteredFiles
    /// </summary>
    [WmiClass(Name = "SMS_MeteredFiles")]
    public class SmsMeteredFiles
    {
        /// <summary>
        /// WMI Property ApplyToChildSites
        /// </summary>
        public bool ApplyToChildSites { get; set; }
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property LanguageID
        /// </summary>
        public uint LanguageId { get; set; }
        /// <summary>
        /// WMI Property MeteredFileID
        /// </summary>
        public long MeteredFileId { get; set; }
        /// <summary>
        /// WMI Property MeteredFileName
        /// </summary>
        public string MeteredFileName { get; set; }
        /// <summary>
        /// WMI Property MeteredFileVersion
        /// </summary>
        public string MeteredFileVersion { get; set; }
        /// <summary>
        /// WMI Property MeteredProductID
        /// </summary>
        public uint MeteredProductId { get; set; }
        /// <summary>
        /// WMI Property MeteredProductLanguage
        /// </summary>
        public uint MeteredProductLanguage { get; set; }
        /// <summary>
        /// WMI Property OriginalFileName
        /// </summary>
        public string OriginalFileName { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property RuleID
        /// </summary>
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property SecurityKey
        /// </summary>
        public string SecurityKey { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
