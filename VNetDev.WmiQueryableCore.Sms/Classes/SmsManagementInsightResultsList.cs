using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ManagementInsightResultsList
    /// </summary>
    [WmiClass(Name = "SMS_ManagementInsightResultsList")]
    public class SmsManagementInsightResultsList
    {
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property QueryId
        /// </summary>
        public string QueryId { get; set; }
    }
}
