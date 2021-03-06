using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SecondarySiteStatus
    /// </summary>
    [WmiClass(Name = "SMS_SecondarySiteStatus")]
    public class SmsSecondarySiteStatus
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property MessageTime
        /// </summary>
        public DateTime MessageTime { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteInstallID
        /// </summary>
        public uint SiteInstallId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusID
        /// </summary>
        public uint StatusId { get; set; }
    }
}
