using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EditionUpgradeConfig
    /// </summary>
    [WmiClass(Name = "SMS_EditionUpgradeConfig")]
    public class SmsEditionUpgradeConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property DeploymentMethod
        /// </summary>
        public uint DeploymentMethod { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enable
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ProductKey
        /// </summary>
        public string ProductKey { get; set; }
        /// <summary>
        /// WMI Property SKU
        /// </summary>
        public uint Sku { get; set; }
    }
}
