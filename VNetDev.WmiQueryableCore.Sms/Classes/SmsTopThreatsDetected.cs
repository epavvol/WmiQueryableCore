using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TopThreatsDetected
    /// </summary>
    [WmiClass(Name = "SMS_TopThreatsDetected")]
    public class SmsTopThreatsDetected
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property MemberCount
        /// </summary>
        public uint MemberCount { get; set; }
        /// <summary>
        /// WMI Property Rank
        /// </summary>
        public uint Rank { get; set; }
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
        /// <summary>
        /// WMI Property TotalMemberCount
        /// </summary>
        public uint TotalMemberCount { get; set; }
    }
}
