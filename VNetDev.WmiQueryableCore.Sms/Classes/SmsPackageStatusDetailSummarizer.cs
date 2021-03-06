using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageStatusDetailSummarizer
    /// </summary>
    [WmiClass(Name = "SMS_PackageStatusDetailSummarizer")]
    public class SmsPackageStatusDetailSummarizer
    {
        /// <summary>
        /// WMI Property Failed
        /// </summary>
        public uint Failed { get; set; }
        /// <summary>
        /// WMI Property Installed
        /// </summary>
        public uint Installed { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property Retrying
        /// </summary>
        public uint Retrying { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property SourceVersion
        /// </summary>
        public uint SourceVersion { get; set; }
        /// <summary>
        /// WMI Property SummaryDate
        /// </summary>
        public DateTime SummaryDate { get; set; }
        /// <summary>
        /// WMI Property Targeted
        /// </summary>
        public uint Targeted { get; set; }
    }
}
