using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DCMDeploymentCompliantAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_DCMDeploymentCompliantAssetDetails")]
    public class SmsDcmDeploymentCompliantAssetDetails
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
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property TargetCollectionID
        /// </summary>
        public string TargetCollectionId { get; set; }
        /// <summary>
        /// WMI Property VMHostName
        /// </summary>
        public string VmHostName { get; set; }
    }
}
