using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClassicDeploymentAssetDetails
    /// </summary>
    [WmiClass(Name = "SMS_ClassicDeploymentAssetDetails")]
    public class SmsClassicDeploymentAssetDetails
    {
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
        /// WMI Property DeviceID
        /// </summary>
        public uint DeviceId { get; set; }
        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
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
        /// WMI Property StatusDescription
        /// </summary>
        public string StatusDescription { get; set; }
        /// <summary>
        /// WMI Property StatusType
        /// </summary>
        public uint StatusType { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
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
