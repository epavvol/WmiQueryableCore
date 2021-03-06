using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppGroupDeploymentAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_AppGroupDeploymentAssetDetails")]
    public class SmsAppGroupDeploymentAssetDetails
    {
        /// <summary>
        /// WMI Property AppGroupComplianceResultID
        /// </summary>
        public ulong AppGroupComplianceResultId { get; set; }
        /// <summary>
        /// WMI Property AppGroupName
        /// </summary>
        public string AppGroupName { get; set; }
        /// <summary>
        /// WMI Property Assignment_UniqueID
        /// </summary>
        [WmiProperty(Name = "Assignment_UniqueID")]
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property GroupModelId
        /// </summary>
        public uint GroupModelId { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
