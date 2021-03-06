using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SUPSyncStatus
    /// </summary>
    [WmiClass(Name = "SMS_SUPSyncStatus")]
    public class SmsSupSyncStatus
    {
        /// <summary>
        /// WMI Property LastReplicationLinkCheckTime
        /// </summary>
        public DateTime LastReplicationLinkCheckTime { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSyncTime
        /// </summary>
        public DateTime LastSuccessfulSyncTime { get; set; }
        /// <summary>
        /// WMI Property LastSyncErrorCode
        /// </summary>
        public uint LastSyncErrorCode { get; set; }
        /// <summary>
        /// WMI Property LastSyncState
        /// </summary>
        public uint LastSyncState { get; set; }
        /// <summary>
        /// WMI Property LastSyncStateTime
        /// </summary>
        public DateTime LastSyncStateTime { get; set; }
        /// <summary>
        /// WMI Property ReplicationLinkStatus
        /// </summary>
        public uint ReplicationLinkStatus { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SyncCatalogVersion
        /// </summary>
        public uint SyncCatalogVersion { get; set; }
        /// <summary>
        /// WMI Property WSUSServerName
        /// </summary>
        public string WsusServerName { get; set; }
        /// <summary>
        /// WMI Property WSUSSourceServer
        /// </summary>
        public string WsusSourceServer { get; set; }
    }
}
