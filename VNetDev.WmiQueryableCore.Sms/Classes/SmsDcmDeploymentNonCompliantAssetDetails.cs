using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DCMDeploymentNonCompliantAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_DCMDeploymentNonCompliantAssetDetails")]
    public class SmsDcmDeploymentNonCompliantAssetDetails
    {
        /// <summary>
        /// WMI Property AssetID
        /// </summary>
        public uint AssetId { get; set; }
        /// <summary>
        /// WMI Property AssetName
        /// </summary>
        public string AssetName { get; set; }
        /// <summary>
        /// WMI Property AssetType
        /// </summary>
        public uint AssetType { get; set; }
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
        /// WMI Property ClientType
        /// </summary>
        public uint ClientType { get; set; }
        /// <summary>
        /// WMI Property ClientTypeDisplay
        /// </summary>
        public string ClientTypeDisplay { get; set; }
        /// <summary>
        /// WMI Property IsBaselineRule
        /// </summary>
        public bool IsBaselineRule { get; set; }
        /// <summary>
        /// WMI Property IsEnforced
        /// </summary>
        public bool IsEnforced { get; set; }
        /// <summary>
        /// WMI Property IsMachineAssignedToUser
        /// </summary>
        public bool IsMachineAssignedToUser { get; set; }
        /// <summary>
        /// WMI Property IsMachineChangesPersisted
        /// </summary>
        public bool IsMachineChangesPersisted { get; set; }
        /// <summary>
        /// WMI Property IsVM
        /// </summary>
        public bool IsVm { get; set; }
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
        /// WMI Property TargetCollectionID
        /// </summary>
        public string TargetCollectionId { get; set; }
        /// <summary>
        /// WMI Property ValidationRule
        /// </summary>
        public string ValidationRule { get; set; }
        /// <summary>
        /// WMI Property VMHostName
        /// </summary>
        public string VmHostName { get; set; }
    }
}
