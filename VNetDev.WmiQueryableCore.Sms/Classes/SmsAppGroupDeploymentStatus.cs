using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppGroupDeploymentStatus
    /// </summary>
    [WmiClass(Name = "SMS_AppGroupDeploymentStatus")]
    public class SmsAppGroupDeploymentStatus
    {
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
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property Total
        /// </summary>
        public uint Total { get; set; }
    }
}
