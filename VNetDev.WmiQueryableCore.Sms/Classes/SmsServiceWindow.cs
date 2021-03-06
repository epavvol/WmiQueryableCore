using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ServiceWindow
    /// </summary>
    [WmiClass(Name = "SMS_ServiceWindow")]
    public class SmsServiceWindow
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Duration
        /// </summary>
        public uint Duration { get; set; }
        /// <summary>
        /// WMI Property IsEnabled
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// WMI Property IsGMT
        /// </summary>
        public bool IsGmt { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property RecurrenceType
        /// </summary>
        public uint RecurrenceType { get; set; }
        /// <summary>
        /// WMI Property ServiceWindowID
        /// </summary>
        public string ServiceWindowId { get; set; }
        /// <summary>
        /// WMI Property ServiceWindowSchedules
        /// </summary>
        public string ServiceWindowSchedules { get; set; }
        /// <summary>
        /// WMI Property ServiceWindowType
        /// </summary>
        public uint ServiceWindowType { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
