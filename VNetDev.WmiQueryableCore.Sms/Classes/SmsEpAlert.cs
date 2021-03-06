using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EPAlert
    /// </summary>
    [WmiClass(Name = "SMS_EPAlert")]
    public class SmsEpAlert
    {
        /// <summary>
        /// WMI method <c>Close</c> describing delegate.
        /// <param name="comments">WMI Property <c>Comments</c> of type <c>string</c>.</param>
        /// <param name="skipUntil">WMI Property <c>SkipUntil</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CloseDelegate(string comments = default, DateTime skipUntil = default);
        /// <summary>
        /// WMI method <c>Close</c>.
        /// </summary>
        public CloseDelegate Close;
        /// <summary>
        /// WMI Property AlertState
        /// </summary>
        public uint AlertState { get; set; }
        /// <summary>
        /// WMI Property ClosedBy
        /// </summary>
        public string ClosedBy { get; set; }
        /// <summary>
        /// WMI Property Comments
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// WMI Property DateAlertStateModified
        /// </summary>
        public DateTime DateAlertStateModified { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateFirstActivated
        /// </summary>
        public DateTime DateFirstActivated { get; set; }
        /// <summary>
        /// WMI Property DateLastModified
        /// </summary>
        public DateTime DateLastModified { get; set; }
        /// <summary>
        /// WMI Property Deletable
        /// </summary>
        public bool Deletable { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property FeatureArea
        /// </summary>
        public uint FeatureArea { get; set; }
        /// <summary>
        /// WMI Property FeatureGroup
        /// </summary>
        public uint FeatureGroup { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property InstanceNameParam1
        /// </summary>
        public string InstanceNameParam1 { get; set; }
        /// <summary>
        /// WMI Property InstanceNameParam2
        /// </summary>
        public string InstanceNameParam2 { get; set; }
        /// <summary>
        /// WMI Property InstanceNameParam3
        /// </summary>
        public string InstanceNameParam3 { get; set; }
        /// <summary>
        /// WMI Property IsIgnored
        /// </summary>
        public bool IsIgnored { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property MonitoredByScom
        /// </summary>
        public bool MonitoredByScom { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberOfSubscription
        /// </summary>
        public uint NumberOfSubscription { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property OccurrenceCount
        /// </summary>
        public uint OccurrenceCount { get; set; }
        /// <summary>
        /// WMI Property ParameterValues
        /// </summary>
        public string ParameterValues { get; set; }
        /// <summary>
        /// WMI Property RootCauseMessage
        /// </summary>
        public string RootCauseMessage { get; set; }
        /// <summary>
        /// WMI Property RuleState
        /// </summary>
        public int RuleState { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public uint Severity { get; set; }
        /// <summary>
        /// WMI Property SkipUntil
        /// </summary>
        public DateTime SkipUntil { get; set; }
        /// <summary>
        /// WMI Property SourceSiteCode
        /// </summary>
        public string SourceSiteCode { get; set; }
        /// <summary>
        /// WMI Property TypeID
        /// </summary>
        public uint TypeId { get; set; }
        /// <summary>
        /// WMI Property TypeInstanceID
        /// </summary>
        public string TypeInstanceId { get; set; }
    }
}
