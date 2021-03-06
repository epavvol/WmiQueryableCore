using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDeploymentFailureBucket
    /// </summary>
    [WmiClass(Name = "SMS_ClientDeploymentFailureBucket")]
    public class SmsClientDeploymentFailureBucket
    {
        /// <summary>
        /// WMI Property ClientCount
        /// </summary>
        public uint ClientCount { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property LastMessageStateID
        /// </summary>
        public uint LastMessageStateId { get; set; }
    }
}
