using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DCMDeploymentCompliantDetailsPerAsset
    /// </summary>
    [WmiClass(Name = "SMS_DCMDeploymentCompliantDetailsPerAsset")]
    public class SmsDcmDeploymentCompliantDetailsPerAsset
    {
        /// <summary>
        /// WMI Property ADUserName
        /// </summary>
        public string AdUserName { get; set; }
        /// <summary>
        /// WMI Property AssetID
        /// </summary>
        public uint AssetId { get; set; }
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
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property DiscoveredValue
        /// </summary>
        public string DiscoveredValue { get; set; }
        /// <summary>
        /// WMI Property InstanceData
        /// </summary>
        public string InstanceData { get; set; }
        /// <summary>
        /// WMI Property IsBaselineRule
        /// </summary>
        public bool IsBaselineRule { get; set; }
        /// <summary>
        /// WMI Property ItemKey
        /// </summary>
        public uint ItemKey { get; set; }
        /// <summary>
        /// WMI Property PreviousValue
        /// </summary>
        public string PreviousValue { get; set; }
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
        /// WMI Property RuleStateDisplay
        /// </summary>
        public string RuleStateDisplay { get; set; }
        /// <summary>
        /// WMI Property RuleSubStateDisplay
        /// </summary>
        public string RuleSubStateDisplay { get; set; }
        /// <summary>
        /// WMI Property Setting_ID
        /// </summary>
        [WmiProperty(Name = "Setting_ID")]
        public uint SettingId { get; set; }
        /// <summary>
        /// WMI Property SettingDescription
        /// </summary>
        public string SettingDescription { get; set; }
        /// <summary>
        /// WMI Property SettingName
        /// </summary>
        public string SettingName { get; set; }
        /// <summary>
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property SubStatusType
        /// </summary>
        public uint SubStatusType { get; set; }
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
