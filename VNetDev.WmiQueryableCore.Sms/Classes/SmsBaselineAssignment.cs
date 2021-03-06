using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BaselineAssignment
    /// </summary>
    [WmiClass(Name = "SMS_BaselineAssignment")]
    public class SmsBaselineAssignment
    {
        /// <summary>
        /// WMI Property ApplyToSubTargets
        /// </summary>
        public bool ApplyToSubTargets { get; set; }
        /// <summary>
        /// WMI Property AssignedCI_UniqueID
        /// </summary>
        [WmiProperty(Name = "AssignedCI_UniqueID")]
        public string AssignedCiUniqueId { get; set; }
        /// <summary>
        /// WMI Property AssignedCIs
        /// </summary>
        public ICollection<int> AssignedCIs { get; set; }
        /// <summary>
        /// WMI Property AssignmentAction
        /// </summary>
        public int AssignmentAction { get; set; }
        /// <summary>
        /// WMI Property AssignmentDescription
        /// </summary>
        public string AssignmentDescription { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public int AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentName
        /// </summary>
        public string AssignmentName { get; set; }
        /// <summary>
        /// WMI Property AssignmentType
        /// </summary>
        public int AssignmentType { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property ContainsExpiredUpdates
        /// </summary>
        public bool ContainsExpiredUpdates { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property DesiredConfigType
        /// </summary>
        public int DesiredConfigType { get; set; }
        /// <summary>
        /// WMI Property DisableMomAlerts
        /// </summary>
        public bool DisableMomAlerts { get; set; }
        /// <summary>
        /// WMI Property DPLocality
        /// </summary>
        public uint DpLocality { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnforcementDeadline
        /// </summary>
        public DateTime EnforcementDeadline { get; set; }
        /// <summary>
        /// WMI Property EnforcementEnabled
        /// </summary>
        public bool EnforcementEnabled { get; set; }
        /// <summary>
        /// WMI Property EvaluationSchedule
        /// </summary>
        public string EvaluationSchedule { get; set; }
        /// <summary>
        /// WMI Property ExpirationTime
        /// </summary>
        public DateTime ExpirationTime { get; set; }
        /// <summary>
        /// WMI Property LastModificationTime
        /// </summary>
        public DateTime LastModificationTime { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property LogComplianceToWinEvent
        /// </summary>
        public bool LogComplianceToWinEvent { get; set; }
        /// <summary>
        /// WMI Property NonComplianceCriticality
        /// </summary>
        public int NonComplianceCriticality { get; set; }
        /// <summary>
        /// WMI Property NotifyUser
        /// </summary>
        public bool NotifyUser { get; set; }
        /// <summary>
        /// WMI Property OverrideServiceWindows
        /// </summary>
        public bool OverrideServiceWindows { get; set; }
        /// <summary>
        /// WMI Property ParentAssignmentID
        /// </summary>
        public int ParentAssignmentId { get; set; }
        /// <summary>
        /// WMI Property PersistOnWriteFilterDevices
        /// </summary>
        public bool PersistOnWriteFilterDevices { get; set; }
        /// <summary>
        /// WMI Property RaiseMomAlertsOnFailure
        /// </summary>
        public bool RaiseMomAlertsOnFailure { get; set; }
        /// <summary>
        /// WMI Property RandomizationMinutes
        /// </summary>
        public uint RandomizationMinutes { get; set; }
        /// <summary>
        /// WMI Property RebootOutsideOfServiceWindows
        /// </summary>
        public bool RebootOutsideOfServiceWindows { get; set; }
        /// <summary>
        /// WMI Property SendDetailedNonComplianceStatus
        /// </summary>
        public bool SendDetailedNonComplianceStatus { get; set; }
        /// <summary>
        /// WMI Property SoftDeadlineEnabled
        /// </summary>
        public bool SoftDeadlineEnabled { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property StateMessagePriority
        /// </summary>
        public uint StateMessagePriority { get; set; }
        /// <summary>
        /// WMI Property SuppressReboot
        /// </summary>
        public uint SuppressReboot { get; set; }
        /// <summary>
        /// WMI Property TargetCollectionID
        /// </summary>
        public string TargetCollectionId { get; set; }
        /// <summary>
        /// WMI Property UseGMTTimes
        /// </summary>
        public bool UseGmtTimes { get; set; }
        /// <summary>
        /// WMI Property WoLEnabled
        /// </summary>
        public bool WoLEnabled { get; set; }
    }
}
