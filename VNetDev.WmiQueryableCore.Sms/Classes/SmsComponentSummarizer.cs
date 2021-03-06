using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ComponentSummarizer
    /// </summary>
    [WmiClass(Name = "SMS_ComponentSummarizer")]
    public class SmsComponentSummarizer
    {
        /// <summary>
        /// WMI static method <c>DeleteStatistics</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteStatisticsDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>DeleteStatistics</c>.
        /// </summary>
        public static DeleteStatisticsDelegate DeleteStatistics;
        /// <summary>
        /// WMI Property AvailabilityState
        /// </summary>
        public uint AvailabilityState { get; set; }
        /// <summary>
        /// WMI Property ComponentName
        /// </summary>
        public string ComponentName { get; set; }
        /// <summary>
        /// WMI Property ComponentType
        /// </summary>
        public string ComponentType { get; set; }
        /// <summary>
        /// WMI Property Errors
        /// </summary>
        public uint Errors { get; set; }
        /// <summary>
        /// WMI Property HeartbeatInterval
        /// </summary>
        public uint HeartbeatInterval { get; set; }
        /// <summary>
        /// WMI Property Infos
        /// </summary>
        public uint Infos { get; set; }
        /// <summary>
        /// WMI Property LastContacted
        /// </summary>
        public DateTime LastContacted { get; set; }
        /// <summary>
        /// WMI Property LastHeartbeat
        /// </summary>
        public DateTime LastHeartbeat { get; set; }
        /// <summary>
        /// WMI Property LastStarted
        /// </summary>
        public DateTime LastStarted { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property NextScheduledTime
        /// </summary>
        public DateTime NextScheduledTime { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property TallyInterval
        /// </summary>
        public string TallyInterval { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property Warnings
        /// </summary>
        public uint Warnings { get; set; }
    }
}
