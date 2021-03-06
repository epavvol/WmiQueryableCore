using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesMachineConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesMachineConfiguration")]
    public class Win32OfflineFilesMachineConfiguration
    {
        /// <summary>
        /// WMI Property BackgroundSyncEnabled
        /// </summary>
        public bool BackgroundSyncEnabled { get; set; }

        /// <summary>
        /// WMI Property BackgroundSyncParams
        /// </summary>
        public Win32OfflineFilesBackgroundSync BackgroundSyncParams { get; set; }

        /// <summary>
        /// WMI Property DiskSpaceLimitEnabled
        /// </summary>
        public bool DiskSpaceLimitEnabled { get; set; }

        /// <summary>
        /// WMI Property DiskSpaceLimitParams
        /// </summary>
        public Win32OfflineFilesDiskSpaceLimit DiskSpaceLimitParams { get; set; }

        /// <summary>
        /// WMI Property EconomicalAdminPinningEnabled
        /// </summary>
        public bool EconomicalAdminPinningEnabled { get; set; }

        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// WMI Property ExcludedFileTypes
        /// </summary>
        public ICollection<string> ExcludedFileTypes { get; set; }

        /// <summary>
        /// WMI Property IsConfiguredByWMI
        /// </summary>
        public bool IsConfiguredByWmi { get; set; }

        /// <summary>
        /// WMI Property MakeAvailableOfflineButtonRemoved
        /// </summary>
        public bool MakeAvailableOfflineButtonRemoved { get; set; }

        /// <summary>
        /// WMI Property OfflineFilesCacheEncrypted
        /// </summary>
        public bool OfflineFilesCacheEncrypted { get; set; }

        /// <summary>
        /// WMI Property SlowLinkEnabled
        /// </summary>
        public bool SlowLinkEnabled { get; set; }

        /// <summary>
        /// WMI Property SlowLinkParams
        /// </summary>
        public ICollection<string> SlowLinkParams { get; set; }

        /// <summary>
        /// WMI Property SyncOnCostedNetworkEnabled
        /// </summary>
        public bool SyncOnCostedNetworkEnabled { get; set; }

        /// <summary>
        /// WMI Property TransparentCachingLatencyThreshold
        /// </summary>
        public uint TransparentCachingLatencyThreshold { get; set; }

        /// <summary>
        /// WMI Property WorkOfflineButtonRemoved
        /// </summary>
        public bool WorkOfflineButtonRemoved { get; set; }
    }
}