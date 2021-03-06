using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_FOLDER_REDIRECTION_HEALTH
    /// </summary>
    [WmiClass(Name = "SMS_G_System_FOLDER_REDIRECTION_HEALTH")]
    public class SmsGSystemFolderRedirectionHealth
    {
        /// <summary>
        /// WMI Property FolderName
        /// </summary>
        public string FolderName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HealthStatus
        /// </summary>
        public uint HealthStatus { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSyncTime
        /// </summary>
        public DateTime LastSuccessfulSyncTime { get; set; }
        /// <summary>
        /// WMI Property LastSyncStatus
        /// </summary>
        public uint LastSyncStatus { get; set; }
        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public DateTime LastSyncTime { get; set; }
        /// <summary>
        /// WMI Property OfflineAccessEnabled
        /// </summary>
        public uint OfflineAccessEnabled { get; set; }
        /// <summary>
        /// WMI Property OfflineFileNameFolderGUID
        /// </summary>
        public string OfflineFileNameFolderGuid { get; set; }
        /// <summary>
        /// WMI Property Redirected
        /// </summary>
        public uint Redirected { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
