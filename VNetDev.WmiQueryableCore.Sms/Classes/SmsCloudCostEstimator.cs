using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CloudCostEstimator
    /// </summary>
    [WmiClass(Name = "SMS_CloudCostEstimator")]
    public class SmsCloudCostEstimator
    {
        /// <summary>
        /// WMI Property AvgContentMBPerMonthPerClient
        /// </summary>
        public uint AvgContentMbPerMonthPerClient { get; set; }
        /// <summary>
        /// WMI Property AvgMPMBPerMonthPerClient
        /// </summary>
        public uint AvgMpmbPerMonthPerClient { get; set; }
        /// <summary>
        /// WMI Property ClientCount
        /// </summary>
        public uint ClientCount { get; set; }
        /// <summary>
        /// WMI Property DesktopCount
        /// </summary>
        public uint DesktopCount { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LaptopCount
        /// </summary>
        public uint LaptopCount { get; set; }
        /// <summary>
        /// WMI Property ServerCount
        /// </summary>
        public uint ServerCount { get; set; }
    }
}
