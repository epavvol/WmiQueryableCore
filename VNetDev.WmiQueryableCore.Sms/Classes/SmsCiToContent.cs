using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIToContent
    /// </summary>
    [WmiClass(Name = "SMS_CIToContent")]
    public class SmsCiToContent
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property ContentDescription
        /// </summary>
        public string ContentDescription { get; set; }
        /// <summary>
        /// WMI Property ContentDownloaded
        /// </summary>
        public bool ContentDownloaded { get; set; }
        /// <summary>
        /// WMI Property ContentHash
        /// </summary>
        public string ContentHash { get; set; }
        /// <summary>
        /// WMI Property ContentHashVersion
        /// </summary>
        public int ContentHashVersion { get; set; }
        /// <summary>
        /// WMI Property ContentID
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// WMI Property ContentLocales
        /// </summary>
        public ICollection<string> ContentLocales { get; set; }
        /// <summary>
        /// WMI Property ContentUniqueID
        /// </summary>
        public string ContentUniqueId { get; set; }
        /// <summary>
        /// WMI Property ContentVersion
        /// </summary>
        public int ContentVersion { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property SDMMethodType
        /// </summary>
        public string SdmMethodType { get; set; }
        /// <summary>
        /// WMI Property SecuredModelName
        /// </summary>
        public string SecuredModelName { get; set; }
    }
}
