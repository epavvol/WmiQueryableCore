using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_M365ADeploymentPlan
    /// </summary>
    [WmiClass(Name = "SMS_M365ADeploymentPlan")]
    public class SmsM365aDeploymentPlan
    {
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property TargetCompletionDate
        /// </summary>
        public DateTime TargetCompletionDate { get; set; }
        /// <summary>
        /// WMI Property Timestamp
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
