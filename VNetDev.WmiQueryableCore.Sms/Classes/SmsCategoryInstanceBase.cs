using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CategoryInstanceBase
    /// </summary>
    [WmiClass(Name = "SMS_CategoryInstanceBase")]
    public class SmsCategoryInstanceBase
    {
        /// <summary>
        /// WMI Property AllowSubscription
        /// </summary>
        public bool AllowSubscription { get; set; }
        /// <summary>
        /// WMI Property CategoryInstance_UniqueID
        /// </summary>
        [WmiProperty(Name = "CategoryInstance_UniqueID")]
        public string CategoryInstanceUniqueId { get; set; }
        /// <summary>
        /// WMI Property CategoryInstanceID
        /// </summary>
        public uint CategoryInstanceId { get; set; }
        /// <summary>
        /// WMI Property CategoryTypeName
        /// </summary>
        public string CategoryTypeName { get; set; }
        /// <summary>
        /// WMI Property IsSubscribed
        /// </summary>
        public bool IsSubscribed { get; set; }
        /// <summary>
        /// WMI Property LocalizedCategoryInstanceName
        /// </summary>
        public string LocalizedCategoryInstanceName { get; set; }
        /// <summary>
        /// WMI Property LocalizedInformation
        /// </summary>
        public  ICollection<SmsCategoryLocalizedProperties> LocalizedInformation { get; set; }
        /// <summary>
        /// WMI Property LocalizedPropertyLocaleID
        /// </summary>
        public uint LocalizedPropertyLocaleId { get; set; }
        /// <summary>
        /// WMI Property ParentCategoryInstanceID
        /// </summary>
        public uint ParentCategoryInstanceId { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
