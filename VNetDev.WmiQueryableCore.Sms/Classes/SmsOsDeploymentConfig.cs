using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OSDeploymentConfig
    /// </summary>
    [WmiClass(Name = "SMS_OSDeploymentConfig")]
    public class SmsOsDeploymentConfig
    {
        /// <summary>
        /// WMI Property DeploymentKitVersion
        /// </summary>
        public string DeploymentKitVersion { get; set; }
        /// <summary>
        /// WMI Property DeploymentPropertyName
        /// </summary>
        public string DeploymentPropertyName { get; set; }
        /// <summary>
        /// WMI Property DeploymentPropertyValue
        /// </summary>
        public string DeploymentPropertyValue { get; set; }
    }
}
