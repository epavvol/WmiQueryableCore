using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SUMDeploymentStatus
    /// </summary>
    [WmiClass(Name = "SMS_SUMDeploymentStatus")]
    public class SmsSumDeploymentStatus
    {
        /// <summary>
        /// WMI Property Assets
        /// </summary>
        public uint Assets { get; set; }
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
        /// WMI Property LastStatusTime
        /// </summary>
        public DateTime LastStatusTime { get; set; }
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
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
    }
}
