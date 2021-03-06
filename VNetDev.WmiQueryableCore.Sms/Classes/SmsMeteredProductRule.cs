using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MeteredProductRule
    /// </summary>
    [WmiClass(Name = "SMS_MeteredProductRule")]
    public class SmsMeteredProductRule
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
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
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
