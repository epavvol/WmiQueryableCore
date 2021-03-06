using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CI_CurrentComplianceStatus
    /// </summary>
    [WmiClass(Name = "SMS_CI_CurrentComplianceStatus")]
    public class SmsCiCurrentComplianceStatus
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property CIVersion
        /// </summary>
        public uint CiVersion { get; set; }
        /// <summary>
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
        /// <summary>
        /// WMI Property ComplianceStateName
        /// </summary>
        public string ComplianceStateName { get; set; }
        /// <summary>
        /// WMI Property ComplianceStatusDetails
        /// </summary>
        public string ComplianceStatusDetails { get; set; }
        /// <summary>
        /// WMI Property ComplianceValidationRuleFailures
        /// </summary>
        public uint ComplianceValidationRuleFailures { get; set; }
        /// <summary>
        /// WMI Property DesiredState
        /// </summary>
        public uint DesiredState { get; set; }
        /// <summary>
        /// WMI Property EnforcementState
        /// </summary>
        public uint EnforcementState { get; set; }
        /// <summary>
        /// WMI Property EnforcementStateName
        /// </summary>
        public string EnforcementStateName { get; set; }
        /// <summary>
        /// WMI Property IsApplicable
        /// </summary>
        public bool IsApplicable { get; set; }
        /// <summary>
        /// WMI Property IsDetected
        /// </summary>
        public bool IsDetected { get; set; }
        /// <summary>
        /// WMI Property LastComplianceMessageTime
        /// </summary>
        public DateTime LastComplianceMessageTime { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageTime
        /// </summary>
        public DateTime LastEnforcementMessageTime { get; set; }
        /// <summary>
        /// WMI Property MaxNoncomplianceCriticality
        /// </summary>
        public uint MaxNoncomplianceCriticality { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SDMPackageVersion
        /// </summary>
        public uint SdmPackageVersion { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
