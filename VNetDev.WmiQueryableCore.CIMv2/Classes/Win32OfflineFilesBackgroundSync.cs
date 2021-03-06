using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesBackgroundSync
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesBackgroundSync")]
    public class Win32OfflineFilesBackgroundSync
    {
        /// <summary>
        /// WMI Property BackgroundSyncWorkOfflineSharesEnabled
        /// </summary>
        public bool BackgroundSyncWorkOfflineSharesEnabled { get; set; }

        /// <summary>
        /// WMI Property BlockOutDurationMin
        /// </summary>
        public ushort BlockOutDurationMin { get; set; }

        /// <summary>
        /// WMI Property BlockOutStartTimeHoursMinutes
        /// </summary>
        public ushort BlockOutStartTimeHoursMinutes { get; set; }

        /// <summary>
        /// WMI Property MaxTimeBetweenSyncs
        /// </summary>
        public ushort MaxTimeBetweenSyncs { get; set; }

        /// <summary>
        /// WMI Property SyncInterval
        /// </summary>
        public ushort SyncInterval { get; set; }

        /// <summary>
        /// WMI Property SyncVariance
        /// </summary>
        public ushort SyncVariance { get; set; }
    }
}