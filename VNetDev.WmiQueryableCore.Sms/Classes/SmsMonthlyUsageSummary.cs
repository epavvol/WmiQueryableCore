using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MonthlyUsageSummary
    /// </summary>
    [WmiClass(Name = "SMS_MonthlyUsageSummary")]
    public class SmsMonthlyUsageSummary
    {
        /// <summary>
        /// WMI Property FileID
        /// </summary>
        public long FileId { get; set; }
        /// <summary>
        /// WMI Property LastUsage
        /// </summary>
        public DateTime LastUsage { get; set; }
        /// <summary>
        /// WMI Property MeteredUserID
        /// </summary>
        public uint MeteredUserId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property TimeKey
        /// </summary>
        public uint TimeKey { get; set; }
        /// <summary>
        /// WMI Property TSUsageCount
        /// </summary>
        public uint TsUsageCount { get; set; }
        /// <summary>
        /// WMI Property UsageCount
        /// </summary>
        public uint UsageCount { get; set; }
        /// <summary>
        /// WMI Property UsageTime
        /// </summary>
        public uint UsageTime { get; set; }
    }
}
