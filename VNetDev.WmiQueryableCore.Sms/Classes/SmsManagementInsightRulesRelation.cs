using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ManagementInsightRules_Relation
    /// </summary>
    [WmiClass(Name = "SMS_ManagementInsightRules_Relation")]
    public class SmsManagementInsightRulesRelation
    {
        /// <summary>
        /// WMI Property LastRunTime
        /// </summary>
        public DateTime LastRunTime { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulRunTime
        /// </summary>
        public DateTime LastSuccessfulRunTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ProgressCatergory
        /// </summary>
        public uint ProgressCatergory { get; set; }
        /// <summary>
        /// WMI Property RelatedRuleId
        /// </summary>
        public string RelatedRuleId { get; set; }
        /// <summary>
        /// WMI Property RelatedRuleOrder
        /// </summary>
        public uint RelatedRuleOrder { get; set; }
        /// <summary>
        /// WMI Property RelationType
        /// </summary>
        public uint RelationType { get; set; }
        /// <summary>
        /// WMI Property RuleID
        /// </summary>
        public string RuleId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
    }
}
