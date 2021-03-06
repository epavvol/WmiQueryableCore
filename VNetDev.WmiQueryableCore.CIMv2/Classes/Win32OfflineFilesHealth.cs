using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesHealth
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesHealth")]
    public class Win32OfflineFilesHealth
    {
        /// <summary>
        /// WMI Property LastSuccessfulSyncTime
        /// </summary>
        public string LastSuccessfulSyncTime { get; set; }

        /// <summary>
        /// WMI Property LastSyncStatus
        /// </summary>
        public byte LastSyncStatus { get; set; }

        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public string LastSyncTime { get; set; }

        /// <summary>
        /// WMI Property OfflineAccessEnabled
        /// </summary>
        public bool OfflineAccessEnabled { get; set; }

        /// <summary>
        /// WMI Property OnlineMode
        /// </summary>
        public bool OnlineMode { get; set; }
    }
}