using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SQLTaskStatus
    /// </summary>
    [WmiClass(Name = "SMS_SQLTaskStatus")]
    public class SmsSqlTaskStatus
    {
        /// <summary>
        /// WMI static method <c>RunTaskNow</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <param name="taskName">WMI Property <c>TaskName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RunTaskNowDelegate(WmiContext wmiContext, string siteCode = default, string taskName = default);
        /// <summary>
        /// WMI static method <c>RunTaskNow</c>.
        /// </summary>
        public static RunTaskNowDelegate RunTaskNow;
        /// <summary>
        /// WMI Property BeginTime
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// WMI Property DaysOfWeek
        /// </summary>
        public uint DaysOfWeek { get; set; }
        /// <summary>
        /// WMI Property Failed
        /// </summary>
        public bool Failed { get; set; }
        /// <summary>
        /// WMI Property IsEnabled
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// WMI Property LastCompletionTime
        /// </summary>
        public DateTime LastCompletionTime { get; set; }
        /// <summary>
        /// WMI Property LastStartTime
        /// </summary>
        public DateTime LastStartTime { get; set; }
        /// <summary>
        /// WMI Property LatestBeginTime
        /// </summary>
        public DateTime LatestBeginTime { get; set; }
        /// <summary>
        /// WMI Property RunNow
        /// </summary>
        public bool RunNow { get; set; }
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
