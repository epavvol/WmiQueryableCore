using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SummaryTask
    /// </summary>
    [WmiClass(Name = "SMS_SummaryTask")]
    public class SmsSummaryTask
    {
        /// <summary>
        /// WMI static method <c>RequestExecution</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskName">WMI Property <c>TaskName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestExecutionDelegate(WmiContext wmiContext, string taskName = default);
        /// <summary>
        /// WMI static method <c>RequestExecution</c>.
        /// </summary>
        public static RequestExecutionDelegate RequestExecution;
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property LastRunDuration
        /// </summary>
        public uint LastRunDuration { get; set; }
        /// <summary>
        /// WMI Property LastRunResult
        /// </summary>
        public uint LastRunResult { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulCompletionTime
        /// </summary>
        public DateTime LastSuccessfulCompletionTime { get; set; }
        /// <summary>
        /// WMI Property NextStartTime
        /// </summary>
        public DateTime NextStartTime { get; set; }
        /// <summary>
        /// WMI Property RunInterval
        /// </summary>
        public uint RunInterval { get; set; }
        /// <summary>
        /// WMI Property RunNow
        /// </summary>
        public bool RunNow { get; set; }
        /// <summary>
        /// WMI Property SiteType
        /// </summary>
        public uint SiteType { get; set; }
        /// <summary>
        /// WMI Property TaskCommand
        /// </summary>
        public string TaskCommand { get; set; }
        /// <summary>
        /// WMI Property TaskID
        /// </summary>
        public uint TaskId { get; set; }
        /// <summary>
        /// WMI Property TaskName
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// WMI Property TaskParameter
        /// </summary>
        public string TaskParameter { get; set; }
    }
}
