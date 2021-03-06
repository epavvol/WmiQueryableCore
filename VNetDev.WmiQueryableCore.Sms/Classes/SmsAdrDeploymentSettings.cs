using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ADRDeploymentSettings
    /// </summary>
    [WmiClass(Name = "SMS_ADRDeploymentSettings")]
    public class SmsAdrDeploymentSettings
    {
        /// <summary>
        /// WMI Property ActionID
        /// </summary>
        public uint ActionId { get; set; }
        /// <summary>
        /// WMI Property AssociatedDeploymentID
        /// </summary>
        public string AssociatedDeploymentId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property DeploymentNumber
        /// </summary>
        public uint DeploymentNumber { get; set; }
        /// <summary>
        /// WMI Property DeploymentTemplate
        /// </summary>
        public string DeploymentTemplate { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property RuleID
        /// </summary>
        public int RuleId { get; set; }
    }
}
