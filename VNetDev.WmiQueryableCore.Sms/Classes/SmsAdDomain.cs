using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ADDomain
    /// </summary>
    [WmiClass(Name = "SMS_ADDomain")]
    public class SmsAdDomain
    {
        /// <summary>
        /// WMI Property DomainID
        /// </summary>
        public uint DomainId { get; set; }
        /// <summary>
        /// WMI Property DomainMode
        /// </summary>
        public string DomainMode { get; set; }
        /// <summary>
        /// WMI Property DomainName
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property ForestID
        /// </summary>
        public uint ForestId { get; set; }
        /// <summary>
        /// WMI Property LastDiscoveryTime
        /// </summary>
        public DateTime LastDiscoveryTime { get; set; }
    }
}
