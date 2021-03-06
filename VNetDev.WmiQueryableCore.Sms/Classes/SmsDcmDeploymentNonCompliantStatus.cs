using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DCMDeploymentNonCompliantStatus
    /// </summary>
    [WmiClass(Name = "SMS_DCMDeploymentNonCompliantStatus")]
    public class SmsDcmDeploymentNonCompliantStatus
    {
        /// <summary>
        /// WMI Property Assets
        /// </summary>
        public uint Assets { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property BL_ID
        /// </summary>
        [WmiProperty(Name = "BL_ID")]
        public uint BlId { get; set; }
        /// <summary>
        /// WMI Property BLName
        /// </summary>
        public string BlName { get; set; }
        /// <summary>
        /// WMI Property BLRevision
        /// </summary>
        public uint BlRevision { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CIName
        /// </summary>
        public string CiName { get; set; }
        /// <summary>
        /// WMI Property DeploymentTime
        /// </summary>
        public DateTime DeploymentTime { get; set; }
        /// <summary>
        /// WMI Property IsBaselineRule
        /// </summary>
        public bool IsBaselineRule { get; set; }
        /// <summary>
        /// WMI Property Revision
        /// </summary>
        public uint Revision { get; set; }
        /// <summary>
        /// WMI Property Rule_ID
        /// </summary>
        [WmiProperty(Name = "Rule_ID")]
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property RuleDescription
        /// </summary>
        public string RuleDescription { get; set; }
        /// <summary>
        /// WMI Property RuleName
        /// </summary>
        public string RuleName { get; set; }
        /// <summary>
        /// WMI Property RuleSeverity
        /// </summary>
        public uint RuleSeverity { get; set; }
        /// <summary>
        /// WMI Property RuleStateDisplay
        /// </summary>
        public string RuleStateDisplay { get; set; }
        /// <summary>
        /// WMI Property RuleSubState
        /// </summary>
        public uint RuleSubState { get; set; }
        /// <summary>
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
        /// <summary>
        /// WMI Property SummaryType
        /// </summary>
        public uint SummaryType { get; set; }
        /// <summary>
        /// WMI Property TargetCollectionID
        /// </summary>
        public string TargetCollectionId { get; set; }
        /// <summary>
        /// WMI Property ValidationRule
        /// </summary>
        public string ValidationRule { get; set; }
    }
}
