using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ADSite
    /// </summary>
    [WmiClass(Name = "SMS_ADSite")]
    public class SmsAdSite
    {
        /// <summary>
        /// WMI Property ADSiteDescription
        /// </summary>
        public string AdSiteDescription { get; set; }
        /// <summary>
        /// WMI Property ADSiteLocation
        /// </summary>
        public string AdSiteLocation { get; set; }
        /// <summary>
        /// WMI Property ADSiteName
        /// </summary>
        public string AdSiteName { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property ForestID
        /// </summary>
        public uint ForestId { get; set; }
        /// <summary>
        /// WMI Property LastDiscoveryTime
        /// </summary>
        public DateTime LastDiscoveryTime { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public uint SiteId { get; set; }
    }
}
