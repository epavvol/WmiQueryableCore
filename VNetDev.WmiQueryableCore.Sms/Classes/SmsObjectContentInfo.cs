using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ObjectContentInfo
    /// </summary>
    [WmiClass(Name = "SMS_ObjectContentInfo")]
    public class SmsObjectContentInfo
    {
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property FeatureType
        /// </summary>
        public uint FeatureType { get; set; }
        /// <summary>
        /// WMI Property LastUpdateDate
        /// </summary>
        public DateTime LastUpdateDate { get; set; }
        /// <summary>
        /// WMI Property NumberErrors
        /// </summary>
        public uint NumberErrors { get; set; }
        /// <summary>
        /// WMI Property NumberInProgress
        /// </summary>
        public uint NumberInProgress { get; set; }
        /// <summary>
        /// WMI Property NumberSuccess
        /// </summary>
        public uint NumberSuccess { get; set; }
        /// <summary>
        /// WMI Property NumberUnknown
        /// </summary>
        public uint NumberUnknown { get; set; }
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property SoftwareName
        /// </summary>
        public string SoftwareName { get; set; }
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
