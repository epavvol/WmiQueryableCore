using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppDTDeploymentSummary
    /// </summary>
    [WmiClass(Name = "SMS_AppDTDeploymentSummary")]
    public class SmsAppDtDeploymentSummary
    {
        /// <summary>
        /// WMI Property AppCI
        /// </summary>
        public uint AppCi { get; set; }
        /// <summary>
        /// WMI Property AppModelName
        /// </summary>
        public string AppModelName { get; set; }
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
        /// WMI Property DeploymentIntent
        /// </summary>
        public uint DeploymentIntent { get; set; }
        /// <summary>
        /// WMI Property DeploymentTime
        /// </summary>
        public DateTime DeploymentTime { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DTCI
        /// </summary>
        public uint Dtci { get; set; }
        /// <summary>
        /// WMI Property DTModelName
        /// </summary>
        public string DtModelName { get; set; }
        /// <summary>
        /// WMI Property ModificationTime
        /// </summary>
        public DateTime ModificationTime { get; set; }
        /// <summary>
        /// WMI Property NumberAlreadyPresent
        /// </summary>
        public int NumberAlreadyPresent { get; set; }
        /// <summary>
        /// WMI Property NumberErrors
        /// </summary>
        public int NumberErrors { get; set; }
        /// <summary>
        /// WMI Property NumberInProgress
        /// </summary>
        public int NumberInProgress { get; set; }
        /// <summary>
        /// WMI Property NumberInstalled
        /// </summary>
        public int NumberInstalled { get; set; }
        /// <summary>
        /// WMI Property NumberReqsNotMet
        /// </summary>
        public int NumberReqsNotMet { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
        /// <summary>
        /// WMI Property Technology
        /// </summary>
        public string Technology { get; set; }
    }
}
