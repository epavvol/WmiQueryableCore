using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ScheduleToken
    /// </summary>
    [WmiClass(Name = "SMS_ScheduleToken")]
    public class SmsScheduleToken
    {
        /// <summary>
        /// WMI Property DayDuration
        /// </summary>
        public uint DayDuration { get; set; }
        /// <summary>
        /// WMI Property HourDuration
        /// </summary>
        public uint HourDuration { get; set; }
        /// <summary>
        /// WMI Property IsGMT
        /// </summary>
        public bool IsGmt { get; set; }
        /// <summary>
        /// WMI Property MinuteDuration
        /// </summary>
        public uint MinuteDuration { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
