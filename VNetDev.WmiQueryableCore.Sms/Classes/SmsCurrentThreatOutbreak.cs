using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CurrentThreatOutbreak
    /// </summary>
    [WmiClass(Name = "SMS_CurrentThreatOutbreak")]
    public class SmsCurrentThreatOutbreak
    {
        /// <summary>
        /// WMI Property FirstDetected
        /// </summary>
        public DateTime FirstDetected { get; set; }
        /// <summary>
        /// WMI Property LastDetected
        /// </summary>
        public DateTime LastDetected { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
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
