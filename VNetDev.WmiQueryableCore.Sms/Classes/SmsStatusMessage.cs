using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StatusMessage
    /// </summary>
    [WmiClass(Name = "SMS_StatusMessage")]
    public class SmsStatusMessage
    {
        /// <summary>
        /// WMI static method <c>RaiseRawStatusMsg</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="attrIDs">WMI Property <c>AttrIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="attrValues">WMI Property <c>AttrValues</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="insStrings">WMI Property <c>InsStrings</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="messageId">WMI Property <c>MessageID</c> of type <c>uint</c>.</param>
        /// <param name="messageType">WMI Property <c>MessageType</c> of type <c>uint</c>.</param>
        /// <param name="moduleName">WMI Property <c>ModuleName</c> of type <c>string</c>.</param>
        /// <param name="processId">WMI Property <c>ProcessID</c> of type <c>uint</c>.</param>
        /// <param name="threadId">WMI Property <c>ThreadID</c> of type <c>uint</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <param name="topLevelSiteCode">WMI Property <c>TopLevelSiteCode</c> of type <c>string</c>.</param>
        /// <param name="win32Error">WMI Property <c>Win32Error</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RaiseRawStatusMsgDelegate(WmiContext wmiContext, ICollection<uint> attrIDs = default, ICollection<string> attrValues = default, ICollection<string> insStrings = default, uint messageId = default, uint messageType = default, string moduleName = default, uint processId = default, uint threadId = default, DateTime time = default, string topLevelSiteCode = default, uint win32Error = default);
        /// <summary>
        /// WMI static method <c>RaiseRawStatusMsg</c>.
        /// </summary>
        public static RaiseRawStatusMsgDelegate RaiseRawStatusMsg;
        
        /// <summary>
        /// WMI static method <c>RaiseErrorStatusMsg</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="attrIDs">WMI Property <c>AttrIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="attrValues">WMI Property <c>AttrValues</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="messageText">WMI Property <c>MessageText</c> of type <c>string</c>.</param>
        /// <param name="messageType">WMI Property <c>MessageType</c> of type <c>uint</c>.</param>
        /// <param name="processId">WMI Property <c>ProcessID</c> of type <c>uint</c>.</param>
        /// <param name="threadId">WMI Property <c>ThreadID</c> of type <c>uint</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <param name="topLevelSiteCode">WMI Property <c>TopLevelSiteCode</c> of type <c>string</c>.</param>
        /// <param name="win32Error">WMI Property <c>Win32Error</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RaiseErrorStatusMsgDelegate(WmiContext wmiContext, ICollection<uint> attrIDs = default, ICollection<string> attrValues = default, string messageText = default, uint messageType = default, uint processId = default, uint threadId = default, DateTime time = default, string topLevelSiteCode = default, uint win32Error = default);
        /// <summary>
        /// WMI static method <c>RaiseErrorStatusMsg</c>.
        /// </summary>
        public static RaiseErrorStatusMsgDelegate RaiseErrorStatusMsg;
        
        /// <summary>
        /// WMI static method <c>RaiseWarningStatusMsg</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="attrIDs">WMI Property <c>AttrIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="attrValues">WMI Property <c>AttrValues</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="messageText">WMI Property <c>MessageText</c> of type <c>string</c>.</param>
        /// <param name="messageType">WMI Property <c>MessageType</c> of type <c>uint</c>.</param>
        /// <param name="processId">WMI Property <c>ProcessID</c> of type <c>uint</c>.</param>
        /// <param name="threadId">WMI Property <c>ThreadID</c> of type <c>uint</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <param name="topLevelSiteCode">WMI Property <c>TopLevelSiteCode</c> of type <c>string</c>.</param>
        /// <param name="win32Error">WMI Property <c>Win32Error</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RaiseWarningStatusMsgDelegate(WmiContext wmiContext, ICollection<uint> attrIDs = default, ICollection<string> attrValues = default, string messageText = default, uint messageType = default, uint processId = default, uint threadId = default, DateTime time = default, string topLevelSiteCode = default, uint win32Error = default);
        /// <summary>
        /// WMI static method <c>RaiseWarningStatusMsg</c>.
        /// </summary>
        public static RaiseWarningStatusMsgDelegate RaiseWarningStatusMsg;
        
        /// <summary>
        /// WMI static method <c>RaiseInformationalStatusMsg</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="attrIDs">WMI Property <c>AttrIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="attrValues">WMI Property <c>AttrValues</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="messageText">WMI Property <c>MessageText</c> of type <c>string</c>.</param>
        /// <param name="messageType">WMI Property <c>MessageType</c> of type <c>uint</c>.</param>
        /// <param name="processId">WMI Property <c>ProcessID</c> of type <c>uint</c>.</param>
        /// <param name="threadId">WMI Property <c>ThreadID</c> of type <c>uint</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <param name="topLevelSiteCode">WMI Property <c>TopLevelSiteCode</c> of type <c>string</c>.</param>
        /// <param name="win32Error">WMI Property <c>Win32Error</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RaiseInformationalStatusMsgDelegate(WmiContext wmiContext, ICollection<uint> attrIDs = default, ICollection<string> attrValues = default, string messageText = default, uint messageType = default, uint processId = default, uint threadId = default, DateTime time = default, string topLevelSiteCode = default, uint win32Error = default);
        /// <summary>
        /// WMI static method <c>RaiseInformationalStatusMsg</c>.
        /// </summary>
        public static RaiseInformationalStatusMsgDelegate RaiseInformationalStatusMsg;
        
        /// <summary>
        /// WMI static method <c>DeleteByID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="recordIDs">WMI Property <c>RecordIDs</c> of type <c>ICollection{long}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteByIdDelegate(WmiContext wmiContext, ICollection<long> recordIDs = default);
        /// <summary>
        /// WMI static method <c>DeleteByID</c>.
        /// </summary>
        public static DeleteByIdDelegate DeleteById;
        
        /// <summary>
        /// WMI static method <c>DeleteByQuery</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="wqlSelect">WMI Property <c>WQLSelect</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DeleteByQueryDelegate(WmiContext wmiContext, string wqlSelect = default);
        /// <summary>
        /// WMI static method <c>DeleteByQuery</c>.
        /// </summary>
        public static DeleteByQueryDelegate DeleteByQuery;
        
        /// <summary>
        /// WMI static method <c>GetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetNextIdDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetNextID</c>.
        /// </summary>
        public static GetNextIdDelegate GetNextId;
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
