using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteSystemSummarizer
    /// </summary>
    [WmiClass(Name = "SMS_SiteSystemSummarizer")]
    public class SmsSiteSystemSummarizer
    {
        /// <summary>
        /// WMI Property AvailabilityState
        /// </summary>
        public uint AvailabilityState { get; set; }
        /// <summary>
        /// WMI Property BytesFree
        /// </summary>
        public long BytesFree { get; set; }
        /// <summary>
        /// WMI Property BytesTotal
        /// </summary>
        public long BytesTotal { get; set; }
        /// <summary>
        /// WMI Property DownSince
        /// </summary>
        public DateTime DownSince { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public uint ObjectType { get; set; }
        /// <summary>
        /// WMI Property PercentFree
        /// </summary>
        public int PercentFree { get; set; }
        /// <summary>
        /// WMI Property Role
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteObject
        /// </summary>
        public string SiteObject { get; set; }
        /// <summary>
        /// WMI Property SiteSystem
        /// </summary>
        public string SiteSystem { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
    }
}
