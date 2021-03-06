using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StatMsg
    /// </summary>
    [WmiClass(Name = "SMS_StatMsg")]
    public class SmsStatMsg
    {
        /// <summary>
        /// WMI Property Component
        /// </summary>
        public string Component { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property MessageType
        /// </summary>
        public uint MessageType { get; set; }
        /// <summary>
        /// WMI Property ModuleName
        /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
        /// WMI Property PerClient
        /// </summary>
        public uint PerClient { get; set; }
        /// <summary>
        /// WMI Property ProcessID
        /// </summary>
        public uint ProcessId { get; set; }
        /// <summary>
        /// WMI Property RecordID
        /// </summary>
        public long RecordId { get; set; }
        /// <summary>
        /// WMI Property ReportFunction
        /// </summary>
        public uint ReportFunction { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public uint Severity { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SuccessfulTransaction
        /// </summary>
        public uint SuccessfulTransaction { get; set; }
        /// <summary>
        /// WMI Property ThreadID
        /// </summary>
        public uint ThreadId { get; set; }
        /// <summary>
        /// WMI Property Time
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// WMI Property TopLevelSiteCode
        /// </summary>
        public string TopLevelSiteCode { get; set; }
        /// <summary>
        /// WMI Property Transaction
        /// </summary>
        public uint Transaction { get; set; }
        /// <summary>
        /// WMI Property Win32Error
        /// </summary>
        public uint Win32Error { get; set; }
    }
}
