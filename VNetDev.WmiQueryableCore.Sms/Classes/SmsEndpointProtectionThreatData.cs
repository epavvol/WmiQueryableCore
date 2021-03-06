using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EndpointProtectionThreatData
    /// </summary>
    [WmiClass(Name = "SMS_EndpointProtectionThreatData")]
    public class SmsEndpointProtectionThreatData
    {
        /// <summary>
        /// WMI Property DefaultActionID
        /// </summary>
        public uint DefaultActionId { get; set; }
        /// <summary>
        /// WMI Property IsAV
        /// </summary>
        public uint IsAv { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ThreatID
        /// </summary>
        public ulong ThreatId { get; set; }
        /// <summary>
        /// WMI Property VersionFirstUpdated
        /// </summary>
        public uint VersionFirstUpdated { get; set; }
    }
}
