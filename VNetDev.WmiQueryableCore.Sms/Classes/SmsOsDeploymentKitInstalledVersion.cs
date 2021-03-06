using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OSDeploymentKitInstalledVersion
    /// </summary>
    [WmiClass(Name = "SMS_OSDeploymentKitInstalledVersion")]
    public class SmsOsDeploymentKitInstalledVersion
    {
        /// <summary>
        /// WMI Property DeploymentKitVersion
        /// </summary>
        public string DeploymentKitVersion { get; set; }
        /// <summary>
        /// WMI Property FQDN
        /// </summary>
        public string Fqdn { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property NetBiosName
        /// </summary>
        public string NetBiosName { get; set; }
    }
}
