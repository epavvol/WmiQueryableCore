using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_R_IPNetwork
    /// </summary>
    [WmiClass(Name = "SMS_R_IPNetwork")]
    public class SmsRIpNetwork
    {
        /// <summary>
        /// WMI Property AgentName
        /// </summary>
        public ICollection<string> AgentName { get; set; }
        /// <summary>
        /// WMI Property AgentSite
        /// </summary>
        public ICollection<string> AgentSite { get; set; }
        /// <summary>
        /// WMI Property AgentTime
        /// </summary>
        public ICollection<DateTime> AgentTime { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ResourceId
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SubnetAddress
        /// </summary>
        public string SubnetAddress { get; set; }
        /// <summary>
        /// WMI Property SubnetMask
        /// </summary>
        public string SubnetMask { get; set; }
        /// <summary>
        /// WMI Property SubnetName
        /// </summary>
        public string SubnetName { get; set; }
        /// <summary>
        /// WMI Property SubnetTopology
        /// </summary>
        public string SubnetTopology { get; set; }
    }
}
