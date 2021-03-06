using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareDistributionAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareDistributionAgentConfig")]
    public class SmsSoftwareDistributionAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property CacheContentTimeout
        /// </summary>
        public uint CacheContentTimeout { get; set; }
        /// <summary>
        /// WMI Property CacheSpaceFailureRetryCount
        /// </summary>
        public uint CacheSpaceFailureRetryCount { get; set; }
        /// <summary>
        /// WMI Property CacheSpaceFailureRetryInterval
        /// </summary>
        public uint CacheSpaceFailureRetryInterval { get; set; }
        /// <summary>
        /// WMI Property CacheTombstoneContentMinDuration
        /// </summary>
        public uint CacheTombstoneContentMinDuration { get; set; }
        /// <summary>
        /// WMI Property ContentLocationTimeoutInterval
        /// </summary>
        public uint ContentLocationTimeoutInterval { get; set; }
        /// <summary>
        /// WMI Property ContentLocationTimeoutRetryCount
        /// </summary>
        public uint ContentLocationTimeoutRetryCount { get; set; }
        /// <summary>
        /// WMI Property DefaultMaxDuration
        /// </summary>
        public uint DefaultMaxDuration { get; set; }
        /// <summary>
        /// WMI Property DisplayNewProgramNotification
        /// </summary>
        public bool DisplayNewProgramNotification { get; set; }
        /// <summary>
        /// WMI Property DownloadModificationInterval
        /// </summary>
        public uint DownloadModificationInterval { get; set; }
        /// <summary>
        /// WMI Property DownloadRetryInterval
        /// </summary>
        public uint DownloadRetryInterval { get; set; }
        /// <summary>
        /// WMI Property ExecutionFailureRetryCount
        /// </summary>
        public uint ExecutionFailureRetryCount { get; set; }
        /// <summary>
        /// WMI Property ExecutionFailureRetryErrorCodes
        /// </summary>
        public ICollection<uint> ExecutionFailureRetryErrorCodes { get; set; }
        /// <summary>
        /// WMI Property ExecutionFailureRetryInterval
        /// </summary>
        public uint ExecutionFailureRetryInterval { get; set; }
        /// <summary>
        /// WMI Property LockSettings
        /// </summary>
        public bool LockSettings { get; set; }
        /// <summary>
        /// WMI Property LogoffReturnCodes
        /// </summary>
        public ICollection<uint> LogoffReturnCodes { get; set; }
        /// <summary>
        /// WMI Property NetworkFailureRetryCount
        /// </summary>
        public uint NetworkFailureRetryCount { get; set; }
        /// <summary>
        /// WMI Property NetworkFailureRetryInterval
        /// </summary>
        public uint NetworkFailureRetryInterval { get; set; }
        /// <summary>
        /// WMI Property NewProgramNotificationUI
        /// </summary>
        public string NewProgramNotificationUi { get; set; }
        /// <summary>
        /// WMI Property RebootLogoffNotification
        /// </summary>
        public bool RebootLogoffNotification { get; set; }
        /// <summary>
        /// WMI Property RebootReturnCodes
        /// </summary>
        public ICollection<uint> RebootReturnCodes { get; set; }
        /// <summary>
        /// WMI Property RunNotification
        /// </summary>
        public bool RunNotification { get; set; }
        /// <summary>
        /// WMI Property RunNotificationCountdownDuration
        /// </summary>
        public uint RunNotificationCountdownDuration { get; set; }
        /// <summary>
        /// WMI Property SuccessReturnCodes
        /// </summary>
        public ICollection<uint> SuccessReturnCodes { get; set; }
        /// <summary>
        /// WMI Property UIContentLocationTimeoutInterval
        /// </summary>
        public uint UiContentLocationTimeoutInterval { get; set; }
        /// <summary>
        /// WMI Property UserPreemptionCountdown
        /// </summary>
        public uint UserPreemptionCountdown { get; set; }
        /// <summary>
        /// WMI Property UserPreemptionTimeout
        /// </summary>
        public uint UserPreemptionTimeout { get; set; }
        /// <summary>
        /// WMI Property WhatsNewDuration
        /// </summary>
        public uint WhatsNewDuration { get; set; }
    }
}
