using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ReplicationLinkStatus
    /// </summary>
    [WmiClass(Name = "SMS_ReplicationLinkStatus")]
    public class SmsReplicationLinkStatus
    {
        /// <summary>
        /// WMI Property ChildLastReceived
        /// </summary>
        public DateTime ChildLastReceived { get; set; }
        /// <summary>
        /// WMI Property ChildLastSent
        /// </summary>
        public DateTime ChildLastSent { get; set; }
        /// <summary>
        /// WMI Property ChildSite
        /// </summary>
        public string ChildSite { get; set; }
        /// <summary>
        /// WMI Property DegradedSyncs
        /// </summary>
        public uint DegradedSyncs { get; set; }
        /// <summary>
        /// WMI Property FailedSyncs
        /// </summary>
        public uint FailedSyncs { get; set; }
        /// <summary>
        /// WMI Property InitializationPercent
        /// </summary>
        public uint InitializationPercent { get; set; }
        /// <summary>
        /// WMI Property InitializationStatus
        /// </summary>
        public uint InitializationStatus { get; set; }
        /// <summary>
        /// WMI Property ParentLastReceived
        /// </summary>
        public DateTime ParentLastReceived { get; set; }
        /// <summary>
        /// WMI Property ParentLastSent
        /// </summary>
        public DateTime ParentLastSent { get; set; }
        /// <summary>
        /// WMI Property ParentSite
        /// </summary>
        public string ParentSite { get; set; }
        /// <summary>
        /// WMI Property RecoveryStatus
        /// </summary>
        public uint RecoveryStatus { get; set; }
        /// <summary>
        /// WMI Property ReplicationGroup
        /// </summary>
        public string ReplicationGroup { get; set; }
        /// <summary>
        /// WMI Property ReplicationPattern
        /// </summary>
        public string ReplicationPattern { get; set; }
        /// <summary>
        /// WMI Property SyncInterval
        /// </summary>
        public uint SyncInterval { get; set; }
    }
}
