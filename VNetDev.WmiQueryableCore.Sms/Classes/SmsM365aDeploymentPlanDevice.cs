using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_M365ADeploymentPlanDevice
    /// </summary>
    [WmiClass(Name = "SMS_M365ADeploymentPlanDevice")]
    public class SmsM365aDeploymentPlanDevice
    {
        /// <summary>
        /// WMI Property DeploymentPlanID
        /// </summary>
        public string DeploymentPlanId { get; set; }
        /// <summary>
        /// WMI Property DeploymentPlanName
        /// </summary>
        public string DeploymentPlanName { get; set; }
        /// <summary>
        /// WMI Property DeploymentPlanStatus
        /// </summary>
        public string DeploymentPlanStatus { get; set; }
        /// <summary>
        /// WMI Property M365ADeviceID
        /// </summary>
        public string M365aDeviceId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OfficeVersion
        /// </summary>
        public string OfficeVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RingType
        /// </summary>
        public string RingType { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
        /// <summary>
        /// WMI Property UpgradeDecision
        /// </summary>
        public string UpgradeDecision { get; set; }
        /// <summary>
        /// WMI Property WindowsVersion
        /// </summary>
        public string WindowsVersion { get; set; }
    }
}
