using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_FileUsageSummary
    /// </summary>
    [WmiClass(Name = "SMS_FileUsageSummary")]
    public class SmsFileUsageSummary
    {
        /// <summary>
        /// WMI Property DistinctUserCount
        /// </summary>
        public uint DistinctUserCount { get; set; }
        /// <summary>
        /// WMI Property FileID
        /// </summary>
        public long FileId { get; set; }
        /// <summary>
        /// WMI Property IntervalStart
        /// </summary>
        public DateTime IntervalStart { get; set; }
        /// <summary>
        /// WMI Property IntervalWidth
        /// </summary>
        public uint IntervalWidth { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
