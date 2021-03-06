using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareUpdateSource
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareUpdateSource")]
    public class SmsSoftwareUpdateSource
    {
        /// <summary>
        /// WMI Property ApplicabilityCondition
        /// </summary>
        public string ApplicabilityCondition { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateModified
        /// </summary>
        public DateTime DateModified { get; set; }
        /// <summary>
        /// WMI Property IsExpired
        /// </summary>
        public bool IsExpired { get; set; }
        /// <summary>
        /// WMI Property PublicKeys
        /// </summary>
        public string PublicKeys { get; set; }
        /// <summary>
        /// WMI Property ScanMethod
        /// </summary>
        public string ScanMethod { get; set; }
        /// <summary>
        /// WMI Property ScanMethodParameters
        /// </summary>
        public string ScanMethodParameters { get; set; }
        /// <summary>
        /// WMI Property ScannerToolPkgID
        /// </summary>
        public string ScannerToolPkgId { get; set; }
        /// <summary>
        /// WMI Property ScanType
        /// </summary>
        public uint ScanType { get; set; }
        /// <summary>
        /// WMI Property SourceContentType
        /// </summary>
        public uint SourceContentType { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property UpdateSourceDescription
        /// </summary>
        public string UpdateSourceDescription { get; set; }
        /// <summary>
        /// WMI Property UpdateSourceID
        /// </summary>
        public uint UpdateSourceId { get; set; }
        /// <summary>
        /// WMI Property UpdateSourceName
        /// </summary>
        public string UpdateSourceName { get; set; }
        /// <summary>
        /// WMI Property UpdateSourceUniqueID
        /// </summary>
        public string UpdateSourceUniqueId { get; set; }
        /// <summary>
        /// WMI Property UpdateSourceVersion
        /// </summary>
        public string UpdateSourceVersion { get; set; }
        /// <summary>
        /// WMI Property UpdateType
        /// </summary>
        public string UpdateType { get; set; }
    }
}
