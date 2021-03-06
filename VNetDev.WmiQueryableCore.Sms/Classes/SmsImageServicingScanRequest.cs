using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageServicingScanRequest
    /// </summary>
    [WmiClass(Name = "SMS_ImageServicingScanRequest")]
    public class SmsImageServicingScanRequest
    {
        /// <summary>
        /// WMI Property ImagePackageID
        /// </summary>
        public string ImagePackageId { get; set; }
        /// <summary>
        /// WMI Property LastRunDateTime
        /// </summary>
        public DateTime LastRunDateTime { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
    }
}
