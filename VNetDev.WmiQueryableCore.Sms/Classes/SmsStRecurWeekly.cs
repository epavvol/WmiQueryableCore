using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ST_RecurWeekly
    /// </summary>
    [WmiClass(Name = "SMS_ST_RecurWeekly")]
    public class SmsStRecurWeekly
    {
        /// <summary>
        /// WMI Property Day
        /// </summary>
        public uint Day { get; set; }
        /// <summary>
        /// WMI Property DayDuration
        /// </summary>
        public uint DayDuration { get; set; }
        /// <summary>
        /// WMI Property ForNumberOfWeeks
        /// </summary>
        public uint ForNumberOfWeeks { get; set; }
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
