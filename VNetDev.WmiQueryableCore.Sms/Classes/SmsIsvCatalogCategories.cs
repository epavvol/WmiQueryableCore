using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ISVCatalogCategories
    /// </summary>
    [WmiClass(Name = "SMS_ISVCatalogCategories")]
    public class SmsIsvCatalogCategories
    {
        /// <summary>
        /// WMI Property CatalogID
        /// </summary>
        public string CatalogId { get; set; }
        /// <summary>
        /// WMI Property DateLastModified
        /// </summary>
        public DateTime DateLastModified { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ParentID
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// WMI Property PublishOption
        /// </summary>
        public int PublishOption { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
