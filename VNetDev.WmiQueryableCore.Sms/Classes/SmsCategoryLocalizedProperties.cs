using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Category_LocalizedProperties
    /// </summary>
    [WmiClass(Name = "SMS_Category_LocalizedProperties")]
    public class SmsCategoryLocalizedProperties
    {
        /// <summary>
        /// WMI Property CategoryInstanceName
        /// </summary>
        public string CategoryInstanceName { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
    }
}
