using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageServicingProgress
    /// </summary>
    [WmiClass(Name = "SMS_ImageServicingProgress")]
    public class SmsImageServicingProgress
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
        /// <summary>
        /// WMI Property Win32ErrorCode
        /// </summary>
        public int Win32ErrorCode { get; set; }
    }
}
