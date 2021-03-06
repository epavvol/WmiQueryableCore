using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EndpointProtectionDashboardBucket
    /// </summary>
    [WmiClass(Name = "SMS_EndpointProtectionDashboardBucket")]
    public class SmsEndpointProtectionDashboardBucket
    {
        /// <summary>
        /// WMI Property Bucket
        /// </summary>
        public string Bucket { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
    }
}
