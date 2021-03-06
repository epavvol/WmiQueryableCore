using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_SQLTask
    /// </summary>
    [WmiClass(Name = "SMS_SCI_SQLTask")]
    public class SmsSciSqlTask
    {
        /// <summary>
        /// WMI Property BeginTime
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// WMI Property DaysOfWeek
        /// </summary>
        public uint DaysOfWeek { get; set; }
        /// <summary>
        /// WMI Property DeleteOlderThan
        /// </summary>
        public uint DeleteOlderThan { get; set; }
        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property LatestBeginTime
        /// </summary>
        public DateTime LatestBeginTime { get; set; }
        /// <summary>
        /// WMI Property NumRefreshDays
        /// </summary>
        public uint NumRefreshDays { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property TaskName
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// WMI Property TaskType
        /// </summary>
        public uint TaskType { get; set; }
    }
}
