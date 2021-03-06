using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OfficePilot
    /// </summary>
    [WmiClass(Name = "SMS_OfficePilot")]
    public class SmsOfficePilot
    {
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property LimitingCollectionID
        /// </summary>
        public uint LimitingCollectionId { get; set; }
        /// <summary>
        /// WMI Property LimitingCollectionSiteID
        /// </summary>
        public string LimitingCollectionSiteId { get; set; }
        /// <summary>
        /// WMI Property PilotCollectionID
        /// </summary>
        public uint PilotCollectionId { get; set; }
        /// <summary>
        /// WMI Property PilotCollectionSiteID
        /// </summary>
        public string PilotCollectionSiteId { get; set; }
    }
}
