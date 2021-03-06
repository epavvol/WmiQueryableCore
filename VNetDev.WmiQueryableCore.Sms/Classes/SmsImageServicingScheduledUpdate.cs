using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ImageServicingScheduledUpdate
    /// </summary>
    [WmiClass(Name = "SMS_ImageServicingScheduledUpdate")]
    public class SmsImageServicingScheduledUpdate
    {
        /// <summary>
        /// WMI Property ScheduleID
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// WMI Property UpdateID
        /// </summary>
        public int UpdateId { get; set; }
    }
}
