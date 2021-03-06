using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageServicingScheduledImage
    /// </summary>
    [WmiClass(Name = "SMS_ImageServicingScheduledImage")]
    public class SmsImageServicingScheduledImage
    {
        /// <summary>
        /// WMI Property ImagePackageID
        /// </summary>
        public string ImagePackageId { get; set; }
        /// <summary>
        /// WMI Property ScheduleID
        /// </summary>
        public int ScheduleId { get; set; }
    }
}
