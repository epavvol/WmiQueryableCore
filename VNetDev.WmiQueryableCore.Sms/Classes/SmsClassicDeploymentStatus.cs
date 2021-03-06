using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClassicDeploymentStatus
    /// </summary>
    [WmiClass(Name = "SMS_ClassicDeploymentStatus")]
    public class SmsClassicDeploymentStatus
    {
        /// <summary>
        /// WMI Property Assets
        /// </summary>
        public uint Assets { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property DeploymentID
        /// </summary>
        public string DeploymentId { get; set; }
        /// <summary>
        /// WMI Property DeploymentTime
        /// </summary>
        public DateTime DeploymentTime { get; set; }
        /// <summary>
        /// WMI Property IsDeviceDeployment
        /// </summary>
        public bool IsDeviceDeployment { get; set; }
        /// <summary>
        /// WMI Property MessageDescription
        /// </summary>
        public string MessageDescription { get; set; }
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageName
        /// </summary>
        public string PackageName { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property Purpose
        /// </summary>
        public uint Purpose { get; set; }
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
