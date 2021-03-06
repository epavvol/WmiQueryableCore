using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_R_UnknownSystem
    /// </summary>
    [WmiClass(Name = "SMS_R_UnknownSystem")]
    public class SmsRUnknownSystem
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
        /// WMI Property CPUType
        /// </summary>
        public string CpuType { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property Decommissioned
        /// </summary>
        public uint Decommissioned { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
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
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SMSAssignedSites
        /// </summary>
        public ICollection<string> SmsAssignedSites { get; set; }
        /// <summary>
        /// WMI Property SMSUniqueIdentifier
        /// </summary>
        public string SmsUniqueIdentifier { get; set; }
    }
}
