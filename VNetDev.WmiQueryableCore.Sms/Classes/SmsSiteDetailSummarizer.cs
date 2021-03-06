using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteDetailSummarizer
    /// </summary>
    [WmiClass(Name = "SMS_SiteDetailSummarizer")]
    public class SmsSiteDetailSummarizer
    {
        /// <summary>
        /// WMI Property AvailabilityState
        /// </summary>
        public uint AvailabilityState { get; set; }
        /// <summary>
        /// WMI Property DatabaseFree
        /// </summary>
        public uint DatabaseFree { get; set; }
        /// <summary>
        /// WMI Property Errors
        /// </summary>
        public uint Errors { get; set; }
        /// <summary>
        /// WMI Property Infos
        /// </summary>
        public uint Infos { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property TallyInterval
        /// </summary>
        public string TallyInterval { get; set; }
        /// <summary>
        /// WMI Property TransFree
        /// </summary>
        public uint TransFree { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property Warnings
        /// </summary>
        public uint Warnings { get; set; }
    }
}
