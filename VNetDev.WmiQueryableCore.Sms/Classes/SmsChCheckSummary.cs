using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CH_CheckSummary
    /// </summary>
    [WmiClass(Name = "SMS_CH_CheckSummary")]
    public class SmsChCheckSummary
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CountCurrent
        /// </summary>
        public uint CountCurrent { get; set; }
        /// <summary>
        /// WMI Property CountRemaining
        /// </summary>
        public uint CountRemaining { get; set; }
        /// <summary>
        /// WMI Property HealthCheckGUID
        /// </summary>
        public string HealthCheckGuid { get; set; }
    }
}
