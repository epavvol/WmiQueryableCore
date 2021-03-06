using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_Property
    /// </summary>
    [WmiClass(Name = "SMS_SCI_Property")]
    public class SmsSciProperty
    {
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property PropertyName
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public uint Value { get; set; }
        /// <summary>
        /// WMI Property Value1
        /// </summary>
        public string Value1 { get; set; }
        /// <summary>
        /// WMI Property Value2
        /// </summary>
        public string Value2 { get; set; }
    }
}
