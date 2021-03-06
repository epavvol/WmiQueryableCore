using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_O365ADRs
    /// </summary>
    [WmiClass(Name = "SMS_O365ADRs")]
    public class SmsO365adRs
    {
        /// <summary>
        /// WMI Property AssociatedDeploymentID
        /// </summary>
        public string AssociatedDeploymentId { get; set; }
        /// <summary>
        /// WMI Property AutoDeploymentID
        /// </summary>
        public uint AutoDeploymentId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
