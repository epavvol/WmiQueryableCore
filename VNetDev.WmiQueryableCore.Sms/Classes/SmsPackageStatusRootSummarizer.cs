using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageStatusRootSummarizer
    /// </summary>
    [WmiClass(Name = "SMS_PackageStatusRootSummarizer")]
    public class SmsPackageStatusRootSummarizer
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
        /// WMI Property SourceCompressedSize
        /// </summary>
        public uint SourceCompressedSize { get; set; }
        /// <summary>
        /// WMI Property SourceDate
        /// </summary>
        public DateTime SourceDate { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property SourceSize
        /// </summary>
        public uint SourceSize { get; set; }
        /// <summary>
        /// WMI Property SourceVersion
        /// </summary>
        public uint SourceVersion { get; set; }
        /// <summary>
        /// WMI Property Targeted
        /// </summary>
        public uint Targeted { get; set; }
    }
}
