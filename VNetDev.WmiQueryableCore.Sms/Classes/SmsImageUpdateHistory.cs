using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageUpdateHistory
    /// </summary>
    [WmiClass(Name = "SMS_ImageUpdateHistory")]
    public class SmsImageUpdateHistory
    {
        /// <summary>
        /// WMI Property FailedUpdateID
        /// </summary>
        public int FailedUpdateId { get; set; }
        /// <summary>
        /// WMI Property ImagePackageID
        /// </summary>
        public string ImagePackageId { get; set; }
        /// <summary>
        /// WMI Property RunDateTime
        /// </summary>
        public DateTime RunDateTime { get; set; }
        /// <summary>
        /// WMI Property ScheduleID
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
    }
}
