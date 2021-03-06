using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ManagementInsightRuleGroups
    /// </summary>
    [WmiClass(Name = "SMS_ManagementInsightRuleGroups")]
    public class SmsManagementInsightRuleGroups
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property RuleGroupDescription
        /// </summary>
        public string RuleGroupDescription { get; set; }
        /// <summary>
        /// WMI Property RuleGroupName
        /// </summary>
        public string RuleGroupName { get; set; }
        /// <summary>
        /// WMI Property TotalCompleted
        /// </summary>
        public uint TotalCompleted { get; set; }
        /// <summary>
        /// WMI Property TotalInProgress
        /// </summary>
        public uint TotalInProgress { get; set; }
        /// <summary>
        /// WMI Property TotalNotCompleted
        /// </summary>
        public uint TotalNotCompleted { get; set; }
        /// <summary>
        /// WMI Property TotalRules
        /// </summary>
        public uint TotalRules { get; set; }
    }
}
