using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeploymentInfoFlat
    /// </summary>
    [WmiClass(Name = "SMS_DeploymentInfoFlat")]
    public class SmsDeploymentInfoFlat
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
        /// WMI Property DeploymentName
        /// </summary>
        public string DeploymentName { get; set; }
        /// <summary>
        /// WMI Property DeploymentTypeID
        /// </summary>
        public uint DeploymentTypeId { get; set; }
        /// <summary>
        /// WMI Property TargetName
        /// </summary>
        public string TargetName { get; set; }
        /// <summary>
        /// WMI Property TargetSecurityTypeID
        /// </summary>
        public uint TargetSecurityTypeId { get; set; }
        /// <summary>
        /// WMI Property TargetSubName
        /// </summary>
        public string TargetSubName { get; set; }
    }
}
