using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_ConditionalAccessCompliance
    /// </summary>
    [WmiClass(Name = "SMS_G_System_ConditionalAccessCompliance")]
    public class SmsGSystemConditionalAccessCompliance
    {
        /// <summary>
        /// WMI Property AADDeviceID
        /// </summary>
        public string AadDeviceId { get; set; }
        /// <summary>
        /// WMI Property ComplianceEvalTime
        /// </summary>
        public string ComplianceEvalTime { get; set; }
        /// <summary>
        /// WMI Property ComplianceSetTime
        /// </summary>
        public string ComplianceSetTime { get; set; }
        /// <summary>
        /// WMI Property ErrorDetails
        /// </summary>
        public string ErrorDetails { get; set; }
        /// <summary>
        /// WMI Property ErrorLocation
        /// </summary>
        public uint ErrorLocation { get; set; }
        /// <summary>
        /// WMI Property IsCompliant
        /// </summary>
        public bool IsCompliant { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SiteNumber
        /// </summary>
        public uint SiteNumber { get; set; }
        /// <summary>
        /// WMI Property UserItemKey
        /// </summary>
        public uint UserItemKey { get; set; }
    }
}
