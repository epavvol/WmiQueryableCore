using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CIDeploymentUnknownStatus
    /// </summary>
    [WmiClass(Name = "SMS_CIDeploymentUnknownStatus")]
    public class SmsCiDeploymentUnknownStatus
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public uint Category { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property DeploymentIntent
        /// </summary>
        public uint DeploymentIntent { get; set; }
        /// <summary>
        /// WMI Property PolicyModelID
        /// </summary>
        public uint PolicyModelId { get; set; }
        /// <summary>
        /// WMI Property SoftwareName
        /// </summary>
        public string SoftwareName { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property Total
        /// </summary>
        public uint Total { get; set; }
    }
}
