using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMDeviceThreat
    /// </summary>
    [WmiClass(Name = "SMS_MDMDeviceThreat")]
    public class SmsMdmDeviceThreat
    {
        /// <summary>
        /// WMI Property AadAccountId
        /// </summary>
        public string AadAccountId { get; set; }
        /// <summary>
        /// WMI Property Classification
        /// </summary>
        public uint Classification { get; set; }
        /// <summary>
        /// WMI Property DeepLinkUrl
        /// </summary>
        public string DeepLinkUrl { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceId
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property EntityType
        /// </summary>
        public uint EntityType { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property PartnerFriendlyName
        /// </summary>
        public string PartnerFriendlyName { get; set; }
        /// <summary>
        /// WMI Property ThreatID
        /// </summary>
        public string ThreatId { get; set; }
        /// <summary>
        /// WMI Property ThreatSeverity
        /// </summary>
        public uint ThreatSeverity { get; set; }
        /// <summary>
        /// WMI Property ThreatSource
        /// </summary>
        public uint ThreatSource { get; set; }
        /// <summary>
        /// WMI Property ThreatStatus
        /// </summary>
        public uint ThreatStatus { get; set; }
        /// <summary>
        /// WMI Property ThreatType
        /// </summary>
        public uint ThreatType { get; set; }
    }
}
