using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIAllCategories
    /// </summary>
    [WmiClass(Name = "SMS_CIAllCategories")]
    public class SmsCiAllCategories
    {
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
        /// WMI Property LocalizedCategoryInstanceName
        /// </summary>
        public string LocalizedCategoryInstanceName { get; set; }
        /// <summary>
        /// WMI Property LocalizedPropertyLocaleID
        /// </summary>
        public uint LocalizedPropertyLocaleId { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
    }
}
