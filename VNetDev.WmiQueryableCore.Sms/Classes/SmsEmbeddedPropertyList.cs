using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EmbeddedPropertyList
    /// </summary>
    [WmiClass(Name = "SMS_EmbeddedPropertyList")]
    public class SmsEmbeddedPropertyList
    {
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
