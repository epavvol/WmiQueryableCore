using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppDeploymentErrorAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_AppDeploymentErrorAssetDetails")]
    public class SmsAppDeploymentErrorAssetDetails
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
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
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
        /// WMI Property DTResultID
        /// </summary>
        public ulong DtResultId { get; set; }
        /// <summary>
        /// WMI Property EnforcementState
        /// </summary>
        public uint EnforcementState { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property ExtendedInfoDescriptionID
        /// </summary>
        public uint ExtendedInfoDescriptionId { get; set; }
        /// <summary>
        /// WMI Property ExtendedInfoID
        /// </summary>
        public uint ExtendedInfoId { get; set; }
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
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property PolicyModelID
        /// </summary>
        public uint PolicyModelId { get; set; }
        /// <summary>
        /// WMI Property Revision
        /// </summary>
        public uint Revision { get; set; }
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
        /// WMI Property UpdateState
        /// </summary>
        public uint UpdateState { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property VMHostName
        /// </summary>
        public string VmHostName { get; set; }
    }
}
