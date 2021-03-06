using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SII_PropertyList
    /// </summary>
    [WmiClass(Name = "SMS_SII_PropertyList")]
    public class SmsSiiPropertyList
    {
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property PropertyListName
        /// </summary>
        public string PropertyListName { get; set; }
        /// <summary>
        /// WMI Property Values
        /// </summary>
        public ICollection<string> Values { get; set; }
    }
}
