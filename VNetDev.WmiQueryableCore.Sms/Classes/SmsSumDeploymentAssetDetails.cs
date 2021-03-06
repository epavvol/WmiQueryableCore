using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SUMDeploymentAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_SUMDeploymentAssetDetails")]
    public class SmsSumDeploymentAssetDetails
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentName
        /// </summary>
        public string AssignmentName { get; set; }
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
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property IsCompliant
        /// </summary>
        public uint IsCompliant { get; set; }
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
        /// WMI Property LastComplianceMessageDesc
        /// </summary>
        public string LastComplianceMessageDesc { get; set; }
        /// <summary>
        /// WMI Property LastComplianceMessageID
        /// </summary>
        public uint LastComplianceMessageId { get; set; }
        /// <summary>
        /// WMI Property LastComplianceMessageTime
        /// </summary>
        public DateTime LastComplianceMessageTime { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementErrorCode
        /// </summary>
        public uint LastEnforcementErrorCode { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementErrorID
        /// </summary>
        public uint LastEnforcementErrorId { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementErrorTime
        /// </summary>
        public DateTime LastEnforcementErrorTime { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageDesc
        /// </summary>
        public string LastEnforcementMessageDesc { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageID
        /// </summary>
        public uint LastEnforcementMessageId { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageTime
        /// </summary>
        public DateTime LastEnforcementMessageTime { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property StatusDescription
        /// </summary>
        public string StatusDescription { get; set; }
        /// <summary>
        /// WMI Property StatusEnforcementState
        /// </summary>
        public uint StatusEnforcementState { get; set; }
        /// <summary>
        /// WMI Property StatusErrorCode
        /// </summary>
        public uint StatusErrorCode { get; set; }
        /// <summary>
        /// WMI Property StatusTime
        /// </summary>
        public DateTime StatusTime { get; set; }
        /// <summary>
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property UserID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// WMI Property VMHostName
        /// </summary>
        public string VmHostName { get; set; }
    }
}
