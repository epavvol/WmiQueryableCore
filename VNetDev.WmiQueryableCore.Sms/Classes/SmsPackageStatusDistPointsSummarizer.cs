using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageStatusDistPointsSummarizer
    /// </summary>
    [WmiClass(Name = "SMS_PackageStatusDistPointsSummarizer")]
    public class SmsPackageStatusDistPointsSummarizer
    {
        /// <summary>
        /// WMI Property LastCopied
        /// </summary>
        public DateTime LastCopied { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property SecuredTypeID
        /// </summary>
        public uint SecuredTypeId { get; set; }
        /// <summary>
        /// WMI Property SecureObjectID
        /// </summary>
        public string SecureObjectId { get; set; }
        /// <summary>
        /// WMI Property ServerNALPath
        /// </summary>
        public string ServerNalPath { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SourceNALPath
        /// </summary>
        public string SourceNalPath { get; set; }
        /// <summary>
        /// WMI Property SourceVersion
        /// </summary>
        public uint SourceVersion { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property SummaryDate
        /// </summary>
        public DateTime SummaryDate { get; set; }
    }
}
