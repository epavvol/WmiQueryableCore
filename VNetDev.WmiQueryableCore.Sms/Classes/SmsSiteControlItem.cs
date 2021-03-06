using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteControlItem
    /// </summary>
    [WmiClass(Name = "SMS_SiteControlItem")]
    public class SmsSiteControlItem
    {
        /// <summary>
        /// WMI Property AddressPriorityOrder
        /// </summary>
        public uint AddressPriorityOrder { get; set; }
        /// <summary>
        /// WMI Property AddressType
        /// </summary>
        public string AddressType { get; set; }
        /// <summary>
        /// WMI Property DesSiteCode
        /// </summary>
        public string DesSiteCode { get; set; }
        /// <summary>
        /// WMI Property DesSiteName
        /// </summary>
        public string DesSiteName { get; set; }
        /// <summary>
        /// WMI Property DestinationType
        /// </summary>
        public uint DestinationType { get; set; }
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
        /// WMI Property PropLists
        /// </summary>
        public  ICollection<SmsEmbeddedPropertyList> PropLists { get; set; }
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public  ICollection<SmsEmbeddedProperty> Props { get; set; }
        /// <summary>
        /// WMI Property RateLimitingSchedule
        /// </summary>
        public ICollection<uint> RateLimitingSchedule { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property UnlimitedRateForAll
        /// </summary>
        public bool UnlimitedRateForAll { get; set; }
        /// <summary>
        /// WMI Property UsageSchedule
        /// </summary>
        public  ICollection<SmsSiteControlDaySchedule> UsageSchedule { get; set; }
    }
}
