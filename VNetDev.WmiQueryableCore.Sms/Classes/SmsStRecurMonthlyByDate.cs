using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ST_RecurMonthlyByDate
    /// </summary>
    [WmiClass(Name = "SMS_ST_RecurMonthlyByDate")]
    public class SmsStRecurMonthlyByDate
    {
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
        /// WMI Property MonthDay
        /// </summary>
        public uint MonthDay { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
