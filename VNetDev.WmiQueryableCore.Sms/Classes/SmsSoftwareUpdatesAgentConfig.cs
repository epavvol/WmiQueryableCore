using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareUpdatesAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareUpdatesAgentConfig")]
    public class SmsSoftwareUpdatesAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property AlternateContentProviders
        /// </summary>
        public string AlternateContentProviders { get; set; }
        /// <summary>
        /// WMI Property AssignmentBatchingTimeout
        /// </summary>
        public uint AssignmentBatchingTimeout { get; set; }
        /// <summary>
        /// WMI Property BrandingSubTitle
        /// </summary>
        public string BrandingSubTitle { get; set; }
        /// <summary>
        /// WMI Property BrandingTitle
        /// </summary>
        public string BrandingTitle { get; set; }
        /// <summary>
        /// WMI Property ContentDownloadTimeout
        /// </summary>
        public uint ContentDownloadTimeout { get; set; }
        /// <summary>
        /// WMI Property ContentLocationTimeout
        /// </summary>
        public uint ContentLocationTimeout { get; set; }
        /// <summary>
        /// WMI Property DayReminderInterval
        /// </summary>
        public uint DayReminderInterval { get; set; }
        /// <summary>
        /// WMI Property DynamicUpdateOption
        /// </summary>
        public uint DynamicUpdateOption { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnableExpressUpdates
        /// </summary>
        public bool EnableExpressUpdates { get; set; }
        /// <summary>
        /// WMI Property EnableThirdPartyUpdates
        /// </summary>
        public bool EnableThirdPartyUpdates { get; set; }
        /// <summary>
        /// WMI Property EvaluationSchedule
        /// </summary>
        public string EvaluationSchedule { get; set; }
        /// <summary>
        /// WMI Property ExpressUpdatesPort
        /// </summary>
        public uint ExpressUpdatesPort { get; set; }
        /// <summary>
        /// WMI Property GroupPolicyNotificationTimeout
        /// </summary>
        public uint GroupPolicyNotificationTimeout { get; set; }
        /// <summary>
        /// WMI Property HourReminderInterval
        /// </summary>
        public uint HourReminderInterval { get; set; }
        /// <summary>
        /// WMI Property MaxRandomDelayMinutes
        /// </summary>
        public uint MaxRandomDelayMinutes { get; set; }
        /// <summary>
        /// WMI Property MaxScanRetryCount
        /// </summary>
        public uint MaxScanRetryCount { get; set; }
        /// <summary>
        /// WMI Property NEOPriorityOption
        /// </summary>
        public uint NeoPriorityOption { get; set; }
        /// <summary>
        /// WMI Property O365Management
        /// </summary>
        public uint O365Management { get; set; }
        /// <summary>
        /// WMI Property PerDPInactivityTimeout
        /// </summary>
        public uint PerDpInactivityTimeout { get; set; }
        /// <summary>
        /// WMI Property ReminderInterval
        /// </summary>
        public uint ReminderInterval { get; set; }
        /// <summary>
        /// WMI Property ScanRetryDelay
        /// </summary>
        public uint ScanRetryDelay { get; set; }
        /// <summary>
        /// WMI Property ScanSchedule
        /// </summary>
        public string ScanSchedule { get; set; }
        /// <summary>
        /// WMI Property ServiceWindowManagement
        /// </summary>
        public bool ServiceWindowManagement { get; set; }
        /// <summary>
        /// WMI Property TotalInactivityTimeout
        /// </summary>
        public uint TotalInactivityTimeout { get; set; }
        /// <summary>
        /// WMI Property UpdateStatusRefreshIntervalDays
        /// </summary>
        public uint UpdateStatusRefreshIntervalDays { get; set; }
        /// <summary>
        /// WMI Property UserExperience
        /// </summary>
        public bool UserExperience { get; set; }
        /// <summary>
        /// WMI Property UserJobPerDPInactivityTimeout
        /// </summary>
        public uint UserJobPerDpInactivityTimeout { get; set; }
        /// <summary>
        /// WMI Property UserJobTotalInactivityTimeout
        /// </summary>
        public uint UserJobTotalInactivityTimeout { get; set; }
        /// <summary>
        /// WMI Property WSUSLocationTimeout
        /// </summary>
        public uint WsusLocationTimeout { get; set; }
        /// <summary>
        /// WMI Property WSUSScanRetryCodes
        /// </summary>
        public ICollection<string> WsusScanRetryCodes { get; set; }
        /// <summary>
        /// WMI Property WUAMaxRebootsWhenOnInternet
        /// </summary>
        public uint WuaMaxRebootsWhenOnInternet { get; set; }
        /// <summary>
        /// WMI Property WUASuccessCodes
        /// </summary>
        public ICollection<string> WuaSuccessCodes { get; set; }
        /// <summary>
        /// WMI Property WUfBEnabled
        /// </summary>
        public bool WUfBEnabled { get; set; }
    }
}
