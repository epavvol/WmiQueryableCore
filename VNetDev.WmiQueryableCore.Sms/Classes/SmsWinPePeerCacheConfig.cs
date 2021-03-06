using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WinPEPeerCacheConfig
    /// </summary>
    [WmiClass(Name = "SMS_WinPEPeerCacheConfig")]
    public class SmsWinPePeerCacheConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property BranchCacheEnabled
        /// </summary>
        public bool BranchCacheEnabled { get; set; }
        /// <summary>
        /// WMI Property BroadcastPort
        /// </summary>
        public uint BroadcastPort { get; set; }
        /// <summary>
        /// WMI Property CachePartialContent
        /// </summary>
        public bool CachePartialContent { get; set; }
        /// <summary>
        /// WMI Property CanBeSuperPeer
        /// </summary>
        public bool CanBeSuperPeer { get; set; }
        /// <summary>
        /// WMI Property ConfigureBranchCache
        /// </summary>
        public bool ConfigureBranchCache { get; set; }
        /// <summary>
        /// WMI Property ConfigureCacheSize
        /// </summary>
        public bool ConfigureCacheSize { get; set; }
        /// <summary>
        /// WMI Property HttpPort
        /// </summary>
        public uint HttpPort { get; set; }
        /// <summary>
        /// WMI Property HttpsEnabled
        /// </summary>
        public bool HttpsEnabled { get; set; }
        /// <summary>
        /// WMI Property MaxAvgDiskQueueLength
        /// </summary>
        public uint MaxAvgDiskQueueLength { get; set; }
        /// <summary>
        /// WMI Property MaxBranchCacheSizePercent
        /// </summary>
        public uint MaxBranchCacheSizePercent { get; set; }
        /// <summary>
        /// WMI Property MaxCacheSizeMB
        /// </summary>
        public uint MaxCacheSizeMb { get; set; }
        /// <summary>
        /// WMI Property MaxCacheSizePercent
        /// </summary>
        public uint MaxCacheSizePercent { get; set; }
        /// <summary>
        /// WMI Property MaxConnectionCountOnClients
        /// </summary>
        public uint MaxConnectionCountOnClients { get; set; }
        /// <summary>
        /// WMI Property MaxConnectionCountOnServers
        /// </summary>
        public uint MaxConnectionCountOnServers { get; set; }
        /// <summary>
        /// WMI Property MaxPercentProcessorTime
        /// </summary>
        public uint MaxPercentProcessorTime { get; set; }
        /// <summary>
        /// WMI Property RejectWhenBatteryLow
        /// </summary>
        public bool RejectWhenBatteryLow { get; set; }
        /// <summary>
        /// WMI Property UsePartialSource
        /// </summary>
        public bool UsePartialSource { get; set; }
    }
}
