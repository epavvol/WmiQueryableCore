using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_FolderRedirectionHealth
    /// </summary>
    [WmiClass(Name = "Win32_FolderRedirectionHealth")]
    public class Win32FolderRedirectionHealth
    {
        /// <summary>
        /// WMI Property HealthStatus
        /// </summary>
        public byte HealthStatus { get; set; }

        /// <summary>
        /// WMI Property LastSuccessfulSyncTime
        /// </summary>
        public DateTime LastSuccessfulSyncTime { get; set; }

        /// <summary>
        /// WMI Property LastSyncStatus
        /// </summary>
        public byte LastSyncStatus { get; set; }

        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public DateTime LastSyncTime { get; set; }

        /// <summary>
        /// WMI Property OfflineAccessEnabled
        /// </summary>
        public bool OfflineAccessEnabled { get; set; }

        /// <summary>
        /// WMI Property OfflineFileNameFolderGUID
        /// </summary>
        public string OfflineFileNameFolderGuid { get; set; }

        /// <summary>
        /// WMI Property Redirected
        /// </summary>
        public bool Redirected { get; set; }
    }
}