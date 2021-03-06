using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppDeploymentRequirementsNotMetStatus
    /// </summary>
    [WmiClass(Name = "SMS_AppDeploymentRequirementsNotMetStatus")]
    public class SmsAppDeploymentRequirementsNotMetStatus
    {
        /// <summary>
        /// WMI Property AppCI
        /// </summary>
        public uint AppCi { get; set; }
        /// <summary>
        /// WMI Property AppName
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// WMI Property AppStatusType
        /// </summary>
        public uint AppStatusType { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property DeploymentIntent
        /// </summary>
        public uint DeploymentIntent { get; set; }
        /// <summary>
        /// WMI Property DTCI
        /// </summary>
        public uint Dtci { get; set; }
        /// <summary>
        /// WMI Property DTModelID
        /// </summary>
        public uint DtModelId { get; set; }
        /// <summary>
        /// WMI Property DTName
        /// </summary>
        public string DtName { get; set; }
        /// <summary>
        /// WMI Property EnforcementState
        /// </summary>
        public uint EnforcementState { get; set; }
        /// <summary>
        /// WMI Property PolicyModelID
        /// </summary>
        public uint PolicyModelId { get; set; }
        /// <summary>
        /// WMI Property RequirementName
        /// </summary>
        public string RequirementName { get; set; }
        /// <summary>
        /// WMI Property RequirementType
        /// </summary>
        public uint RequirementType { get; set; }
        /// <summary>
        /// WMI Property RuleID
        /// </summary>
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property Technology
        /// </summary>
        public string Technology { get; set; }
        /// <summary>
        /// WMI Property Total
        /// </summary>
        public uint Total { get; set; }
    }
}
