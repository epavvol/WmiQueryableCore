using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareMeteringAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareMeteringAgentConfig")]
    public class SmsSoftwareMeteringAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property DataCollectionSchedule
        /// </summary>
        public string DataCollectionSchedule { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTimeOfRules
        /// </summary>
        public string LastUpdateTimeOfRules { get; set; }
        /// <summary>
        /// WMI Property MaximumUsageInstancesPerReport
        /// </summary>
        public uint MaximumUsageInstancesPerReport { get; set; }
        /// <summary>
        /// WMI Property MeterRuleIDList
        /// </summary>
        public ICollection<string> MeterRuleIdList { get; set; }
        /// <summary>
        /// WMI Property MRUAgeLimitInDays
        /// </summary>
        public uint MruAgeLimitInDays { get; set; }
        /// <summary>
        /// WMI Property MRURefreshInMinutes
        /// </summary>
        public uint MruRefreshInMinutes { get; set; }
        /// <summary>
        /// WMI Property ReportTimeout
        /// </summary>
        public uint ReportTimeout { get; set; }
    }
}
