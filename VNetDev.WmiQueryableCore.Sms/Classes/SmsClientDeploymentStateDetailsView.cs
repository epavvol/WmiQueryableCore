using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDeploymentStateDetailsView
    /// </summary>
    [WmiClass(Name = "SMS_ClientDeploymentStateDetailsView")]
    public class SmsClientDeploymentStateDetailsView
    {
        /// <summary>
        /// WMI Property BaselineItemID
        /// </summary>
        public uint BaselineItemId { get; set; }
        /// <summary>
        /// WMI Property BaselineItemName
        /// </summary>
        public string BaselineItemName { get; set; }
        /// <summary>
        /// WMI Property BaselineItemType
        /// </summary>
        public uint BaselineItemType { get; set; }
        /// <summary>
        /// WMI Property NetBiosName
        /// </summary>
        public string NetBiosName { get; set; }
        /// <summary>
        /// WMI Property RecordID
        /// </summary>
        public uint RecordId { get; set; }
        /// <summary>
        /// WMI Property SMSID
        /// </summary>
        public string Smsid { get; set; }
    }
}
