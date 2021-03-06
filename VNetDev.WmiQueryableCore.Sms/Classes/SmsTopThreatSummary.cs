using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TopThreatSummary
    /// </summary>
    [WmiClass(Name = "SMS_TopThreatSummary")]
    public class SmsTopThreatSummary
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionMembers
        /// </summary>
        public uint CollectionMembers { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property FailedCount
        /// </summary>
        public uint FailedCount { get; set; }
        /// <summary>
        /// WMI Property FirstDetectionTime
        /// </summary>
        public DateTime FirstDetectionTime { get; set; }
        /// <summary>
        /// WMI Property InfectedCount
        /// </summary>
        public uint InfectedCount { get; set; }
        /// <summary>
        /// WMI Property IsAllowed
        /// </summary>
        public bool IsAllowed { get; set; }
        /// <summary>
        /// WMI Property IsExcluded
        /// </summary>
        public bool IsExcluded { get; set; }
        /// <summary>
        /// WMI Property IsRestored
        /// </summary>
        public bool IsRestored { get; set; }
        /// <summary>
        /// WMI Property LastDetectionTime
        /// </summary>
        public DateTime LastDetectionTime { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property PendingCount
        /// </summary>
        public uint PendingCount { get; set; }
        /// <summary>
        /// WMI Property RemediatedCount
        /// </summary>
        public uint RemediatedCount { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public uint Severity { get; set; }
        /// <summary>
        /// WMI Property ThreatCategoryID
        /// </summary>
        public uint ThreatCategoryId { get; set; }
        /// <summary>
        /// WMI Property ThreatID
        /// </summary>
        public ulong ThreatId { get; set; }
        /// <summary>
        /// WMI Property ThreatName
        /// </summary>
        public string ThreatName { get; set; }
    }
}
