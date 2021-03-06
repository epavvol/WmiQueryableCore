using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_EPDeploymentState
    /// </summary>
    [WmiClass(Name = "SMS_G_System_EPDeploymentState")]
    public class SmsGSystemEpDeploymentState
    {
        /// <summary>
        /// WMI Property DeploymentState
        /// </summary>
        public uint DeploymentState { get; set; }
        /// <summary>
        /// WMI Property Error
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property LastMessageTime
        /// </summary>
        public DateTime LastMessageTime { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
