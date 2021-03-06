using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StatMsgWithInsStrings
    /// </summary>
    [WmiClass(Name = "SMS_StatMsgWithInsStrings")]
    public class SmsStatMsgWithInsStrings
    {
        /// <summary>
        /// WMI Property Component
        /// </summary>
        public string Component { get; set; }
        /// <summary>
        /// WMI Property InsString1
        /// </summary>
        public string InsString1 { get; set; }
        /// <summary>
        /// WMI Property InsString10
        /// </summary>
        public string InsString10 { get; set; }
        /// <summary>
        /// WMI Property InsString2
        /// </summary>
        public string InsString2 { get; set; }
        /// <summary>
        /// WMI Property InsString3
        /// </summary>
        public string InsString3 { get; set; }
        /// <summary>
        /// WMI Property InsString4
        /// </summary>
        public string InsString4 { get; set; }
        /// <summary>
        /// WMI Property InsString5
        /// </summary>
        public string InsString5 { get; set; }
        /// <summary>
        /// WMI Property InsString6
        /// </summary>
        public string InsString6 { get; set; }
        /// <summary>
        /// WMI Property InsString7
        /// </summary>
        public string InsString7 { get; set; }
        /// <summary>
        /// WMI Property InsString8
        /// </summary>
        public string InsString8 { get; set; }
        /// <summary>
        /// WMI Property InsString9
        /// </summary>
        public string InsString9 { get; set; }
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
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
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
