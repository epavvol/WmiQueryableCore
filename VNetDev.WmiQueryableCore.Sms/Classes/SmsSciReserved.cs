using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_Reserved
    /// </summary>
    [WmiClass(Name = "SMS_SCI_Reserved")]
    public class SmsSciReserved
    {
        /// <summary>
        /// WMI Property AccountUsage
        /// </summary>
        public ICollection<string> AccountUsage { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property Flag
        /// </summary>
        public uint Flag { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property PropLists
        /// </summary>
        public  ICollection<SmsEmbeddedPropertyList> PropLists { get; set; }
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public  ICollection<SmsEmbeddedProperty> Props { get; set; }
        /// <summary>
        /// WMI Property Reserved2
        /// </summary>
        public string Reserved2 { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
