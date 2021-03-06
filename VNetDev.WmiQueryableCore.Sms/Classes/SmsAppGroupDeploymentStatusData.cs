using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppGroupDeploymentStatusData
    /// </summary>
    [WmiClass(Name = "SMS_AppGroupDeploymentStatusData")]
    public class SmsAppGroupDeploymentStatusData
    {
        /// <summary>
        /// WMI Property AppGroupComplianceResultID
        /// </summary>
        public ulong AppGroupComplianceResultId { get; set; }
        /// <summary>
        /// WMI Property Assignment_UniqueID
        /// </summary>
        [WmiProperty(Name = "Assignment_UniqueID")]
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
        /// <summary>
        /// WMI Property EnforcementState
        /// </summary>
        public uint EnforcementState { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property GroupModelId
        /// </summary>
        public uint GroupModelId { get; set; }
        /// <summary>
        /// WMI Property ItemDisplayName
        /// </summary>
        public string ItemDisplayName { get; set; }
        /// <summary>
        /// WMI Property ItemModelId
        /// </summary>
        public uint ItemModelId { get; set; }
        /// <summary>
        /// WMI Property ItemOrder
        /// </summary>
        public uint ItemOrder { get; set; }
        /// <summary>
        /// WMI Property ItemStateCIVersion
        /// </summary>
        public uint ItemStateCiVersion { get; set; }
        /// <summary>
        /// WMI Property LastStateUpdateTime
        /// </summary>
        public DateTime LastStateUpdateTime { get; set; }
    }
}
