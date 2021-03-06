using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ManagementInsights
    /// </summary>
    [WmiClass(Name = "SMS_ManagementInsights")]
    public class SmsManagementInsights
    {
        /// <summary>
        /// WMI method <c>ReEvaluateRule</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReEvaluateRuleDelegate();
        /// <summary>
        /// WMI method <c>ReEvaluateRule</c>.
        /// </summary>
        public ReEvaluateRuleDelegate ReEvaluateRule;
        /// <summary>
        /// WMI Property ActionDetail
        /// </summary>
        public string ActionDetail { get; set; }
        /// <summary>
        /// WMI Property ActionType
        /// </summary>
        public uint ActionType { get; set; }
        /// <summary>
        /// WMI Property Active
        /// </summary>
        public uint Active { get; set; }
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public uint Category { get; set; }
        /// <summary>
        /// WMI Property Duration
        /// </summary>
        public uint Duration { get; set; }
        /// <summary>
        /// WMI Property Error
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property LastRunTime
        /// </summary>
        public DateTime LastRunTime { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulRunTime
        /// </summary>
        public DateTime LastSuccessfulRunTime { get; set; }
        /// <summary>
        /// WMI Property MoreInfoLink
        /// </summary>
        public string MoreInfoLink { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ProgressCatergory
        /// </summary>
        public uint ProgressCatergory { get; set; }
        /// <summary>
        /// WMI Property Results
        /// </summary>
        public string Results { get; set; }
        /// <summary>
        /// WMI Property RuleDescription
        /// </summary>
        public string RuleDescription { get; set; }
        /// <summary>
        /// WMI Property Site
        /// </summary>
        public uint Site { get; set; }
        /// <summary>
        /// WMI Property SiteNumber
        /// </summary>
        public uint SiteNumber { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// WMI Property WMIClassName
        /// </summary>
        public string WmiClassName { get; set; }
        /// <summary>
        /// WMI Property WMIKeyName
        /// </summary>
        public string WmiKeyName { get; set; }
        /// <summary>
        /// WMI Property WMISelectColumns
        /// </summary>
        public string WmiSelectColumns { get; set; }
    }
}
