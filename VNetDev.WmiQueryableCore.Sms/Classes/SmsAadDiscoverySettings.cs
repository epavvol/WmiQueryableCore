using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Discovery_Settings
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Discovery_Settings")]
    public class SmsAadDiscoverySettings
    {
        /// <summary>
        /// WMI Property AgentType
        /// </summary>
        public uint AgentType { get; set; }
        /// <summary>
        /// WMI Property CloudServiceId
        /// </summary>
        public uint CloudServiceId { get; set; }
        /// <summary>
        /// WMI Property DeltaSyncEnabled
        /// </summary>
        public bool DeltaSyncEnabled { get; set; }
        /// <summary>
        /// WMI Property DeltaSyncInterval
        /// </summary>
        public uint DeltaSyncInterval { get; set; }
        /// <summary>
        /// WMI Property DiscoveryScopeIds
        /// </summary>
        public ICollection<string> DiscoveryScopeIds { get; set; }
        /// <summary>
        /// WMI Property DiscoveryScopeNames
        /// </summary>
        public ICollection<string> DiscoveryScopeNames { get; set; }
        /// <summary>
        /// WMI Property FullSyncEnabled
        /// </summary>
        public bool FullSyncEnabled { get; set; }
        /// <summary>
        /// WMI Property FullSyncSchedule
        /// </summary>
        public string FullSyncSchedule { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LastDeltaSyncTime
        /// </summary>
        public DateTime LastDeltaSyncTime { get; set; }
        /// <summary>
        /// WMI Property LastFullSyncTime
        /// </summary>
        public DateTime LastFullSyncTime { get; set; }
        /// <summary>
        /// WMI Property RunNow
        /// </summary>
        public bool RunNow { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
