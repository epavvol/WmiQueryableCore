using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OverallThreatActivity
    /// </summary>
    [WmiClass(Name = "SMS_OverallThreatActivity")]
    public class SmsOverallThreatActivity
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property FullscanRequiredCount
        /// </summary>
        public uint FullscanRequiredCount { get; set; }
        /// <summary>
        /// WMI Property InfectedCount
        /// </summary>
        public uint InfectedCount { get; set; }
        /// <summary>
        /// WMI Property ManualStepsRequiredCount
        /// </summary>
        public uint ManualStepsRequiredCount { get; set; }
        /// <summary>
        /// WMI Property OfflineScanRequiredCount
        /// </summary>
        public uint OfflineScanRequiredCount { get; set; }
        /// <summary>
        /// WMI Property RecentlyCleanedCount
        /// </summary>
        public uint RecentlyCleanedCount { get; set; }
        /// <summary>
        /// WMI Property RestartRequiredCount
        /// </summary>
        public uint RestartRequiredCount { get; set; }
        /// <summary>
        /// WMI Property ThreatActivityCount
        /// </summary>
        public uint ThreatActivityCount { get; set; }
        /// <summary>
        /// WMI Property TimeLastUpdated
        /// </summary>
        public DateTime TimeLastUpdated { get; set; }
        /// <summary>
        /// WMI Property TotalMemberCount
        /// </summary>
        public uint TotalMemberCount { get; set; }
    }
}
