using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ReplicationLinkSummary
    /// </summary>
    [WmiClass(Name = "SMS_ReplicationLinkSummary")]
    public class SmsReplicationLinkSummary
    {
        /// <summary>
        /// WMI Property GlobalInitPercentage
        /// </summary>
        public string GlobalInitPercentage { get; set; }
        /// <summary>
        /// WMI Property LinkStatus
        /// </summary>
        public uint LinkStatus { get; set; }
        /// <summary>
        /// WMI Property LinkStatusDescription
        /// </summary>
        public uint LinkStatusDescription { get; set; }
        /// <summary>
        /// WMI Property Site1
        /// </summary>
        public string Site1 { get; set; }
        /// <summary>
        /// WMI Property Site1Status
        /// </summary>
        public uint Site1Status { get; set; }
        /// <summary>
        /// WMI Property Site1ToSite2GlobalState
        /// </summary>
        public uint Site1ToSite2GlobalState { get; set; }
        /// <summary>
        /// WMI Property Site1ToSite2GlobalSyncTime
        /// </summary>
        public DateTime Site1ToSite2GlobalSyncTime { get; set; }
        /// <summary>
        /// WMI Property Site2
        /// </summary>
        public string Site2 { get; set; }
        /// <summary>
        /// WMI Property Site2Status
        /// </summary>
        public uint Site2Status { get; set; }
        /// <summary>
        /// WMI Property Site2ToSite1GlobalState
        /// </summary>
        public uint Site2ToSite1GlobalState { get; set; }
        /// <summary>
        /// WMI Property Site2ToSite1GlobalSyncTime
        /// </summary>
        public DateTime Site2ToSite1GlobalSyncTime { get; set; }
        /// <summary>
        /// WMI Property Site2ToSite1SiteState
        /// </summary>
        public uint Site2ToSite1SiteState { get; set; }
        /// <summary>
        /// WMI Property Site2ToSite1SiteSyncTime
        /// </summary>
        public DateTime Site2ToSite1SiteSyncTime { get; set; }
        /// <summary>
        /// WMI Property SiteName1
        /// </summary>
        public string SiteName1 { get; set; }
        /// <summary>
        /// WMI Property SiteName2
        /// </summary>
        public string SiteName2 { get; set; }
        /// <summary>
        /// WMI Property SiteType1
        /// </summary>
        public uint SiteType1 { get; set; }
        /// <summary>
        /// WMI Property SiteType2
        /// </summary>
        public uint SiteType2 { get; set; }
    }
}
