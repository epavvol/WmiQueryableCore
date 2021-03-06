using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ADForestDiscoveryStatus
    /// </summary>
    [WmiClass(Name = "SMS_ADForestDiscoveryStatus")]
    public class SmsAdForestDiscoveryStatus
    {
        /// <summary>
        /// WMI Property DiscoveryEnabled
        /// </summary>
        public bool DiscoveryEnabled { get; set; }
        /// <summary>
        /// WMI Property DiscoveryStatus
        /// </summary>
        public uint DiscoveryStatus { get; set; }
        /// <summary>
        /// WMI Property ForestID
        /// </summary>
        public uint ForestId { get; set; }
        /// <summary>
        /// WMI Property LastDiscoveryTime
        /// </summary>
        public DateTime LastDiscoveryTime { get; set; }
        /// <summary>
        /// WMI Property LastPublishingTime
        /// </summary>
        public DateTime LastPublishingTime { get; set; }
        /// <summary>
        /// WMI Property PublishingEnabled
        /// </summary>
        public bool PublishingEnabled { get; set; }
        /// <summary>
        /// WMI Property PublishingStatus
        /// </summary>
        public uint PublishingStatus { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
    }
}
