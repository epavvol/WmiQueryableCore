using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_User_DCMDeploymentState
    /// </summary>
    [WmiClass(Name = "SMS_G_User_DCMDeploymentState")]
    public class SmsGUserDcmDeploymentState
    {
        /// <summary>
        /// WMI Property BaselineID
        /// </summary>
        public string BaselineId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property ComplianceState
        /// </summary>
        public uint ComplianceState { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceName
        /// </summary>
        public string ResourceName { get; set; }
    }
}
