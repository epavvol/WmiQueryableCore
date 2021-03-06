using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeploymentInfo
    /// </summary>
    [WmiClass(Name = "SMS_DeploymentInfo")]
    public class SmsDeploymentInfo
    {
        /// <summary>
        /// WMI static method <c>GetDeployments</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetDeploymentsDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>GetDeployments</c>.
        /// </summary>
        public static GetDeploymentsDelegate GetDeployments;
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
        /// WMI Property DeploymentIntent
        /// </summary>
        public uint DeploymentIntent { get; set; }
        /// <summary>
        /// WMI Property DeploymentName
        /// </summary>
        public string DeploymentName { get; set; }
        /// <summary>
        /// WMI Property DeploymentType
        /// </summary>
        public uint DeploymentType { get; set; }
        /// <summary>
        /// WMI Property DeploymentTypeID
        /// </summary>
        public uint DeploymentTypeId { get; set; }
        /// <summary>
        /// WMI Property TargetID
        /// </summary>
        public string TargetId { get; set; }
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
