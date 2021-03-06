using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_TIME_ZONE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_TIME_ZONE")]
    public class SmsGehSystemTimeZone
    {
        /// <summary>
        /// WMI Property Bias
        /// </summary>
        public uint Bias { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property DaylightBias
        /// </summary>
        public uint DaylightBias { get; set; }
        /// <summary>
        /// WMI Property DaylightDay
        /// </summary>
        public uint DaylightDay { get; set; }
        /// <summary>
        /// WMI Property DaylightDayOfWeek
        /// </summary>
        public uint DaylightDayOfWeek { get; set; }
        /// <summary>
        /// WMI Property DaylightHour
        /// </summary>
        public uint DaylightHour { get; set; }
        /// <summary>
        /// WMI Property DaylightMillisecond
        /// </summary>
        public uint DaylightMillisecond { get; set; }
        /// <summary>
        /// WMI Property DaylightMinute
        /// </summary>
        public uint DaylightMinute { get; set; }
        /// <summary>
        /// WMI Property DaylightMonth
        /// </summary>
        public uint DaylightMonth { get; set; }
        /// <summary>
        /// WMI Property DaylightName
        /// </summary>
        public string DaylightName { get; set; }
        /// <summary>
        /// WMI Property DaylightSecond
        /// </summary>
        public uint DaylightSecond { get; set; }
        /// <summary>
        /// WMI Property DaylightYear
        /// </summary>
        public uint DaylightYear { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property StandardBias
        /// </summary>
        public uint StandardBias { get; set; }
        /// <summary>
        /// WMI Property StandardDay
        /// </summary>
        public uint StandardDay { get; set; }
        /// <summary>
        /// WMI Property StandardDayOfWeek
        /// </summary>
        public uint StandardDayOfWeek { get; set; }
        /// <summary>
        /// WMI Property StandardHour
        /// </summary>
        public uint StandardHour { get; set; }
        /// <summary>
        /// WMI Property StandardMillisecond
        /// </summary>
        public uint StandardMillisecond { get; set; }
        /// <summary>
        /// WMI Property StandardMinute
        /// </summary>
        public uint StandardMinute { get; set; }
        /// <summary>
        /// WMI Property StandardMonth
        /// </summary>
        public uint StandardMonth { get; set; }
        /// <summary>
        /// WMI Property StandardName
        /// </summary>
        public string StandardName { get; set; }
        /// <summary>
        /// WMI Property StandardSecond
        /// </summary>
        public uint StandardSecond { get; set; }
        /// <summary>
        /// WMI Property StandardYear
        /// </summary>
        public uint StandardYear { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
