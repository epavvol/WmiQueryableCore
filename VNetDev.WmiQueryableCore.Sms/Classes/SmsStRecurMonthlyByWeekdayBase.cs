using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ST_RecurMonthlyByWeekdayBase
    /// </summary>
    [WmiClass(Name = "SMS_ST_RecurMonthlyByWeekdayBase")]
    public class SmsStRecurMonthlyByWeekdayBase
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
        /// WMI Property ForNumberOfMonths
        /// </summary>
        public uint ForNumberOfMonths { get; set; }
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
        /// WMI Property OffsetDay
        /// </summary>
        public uint OffsetDay { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property WeekOrder
        /// </summary>
        public uint WeekOrder { get; set; }
    }
}
