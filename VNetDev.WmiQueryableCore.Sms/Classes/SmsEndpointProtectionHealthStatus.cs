using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EndpointProtectionHealthStatus
    /// </summary>
    [WmiClass(Name = "SMS_EndpointProtectionHealthStatus")]
    public class SmsEndpointProtectionHealthStatus
    {
        /// <summary>
        /// WMI Property ApplyPolicyFailedCount
        /// </summary>
        public uint ApplyPolicyFailedCount { get; set; }
        /// <summary>
        /// WMI Property ApplyPolicySucceededCount
        /// </summary>
        public uint ApplyPolicySucceededCount { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property InstallFailedCount
        /// </summary>
        public uint InstallFailedCount { get; set; }
        /// <summary>
        /// WMI Property InstallRebootPendingCount
        /// </summary>
        public uint InstallRebootPendingCount { get; set; }
        /// <summary>
        /// WMI Property NoSignatureCount
        /// </summary>
        public uint NoSignatureCount { get; set; }
        /// <summary>
        /// WMI Property OverallNotClientCount
        /// </summary>
        public uint OverallNotClientCount { get; set; }
        /// <summary>
        /// WMI Property OverallStatusAtRiskCount
        /// </summary>
        public uint OverallStatusAtRiskCount { get; set; }
        /// <summary>
        /// WMI Property OverallStatusInactiveCount
        /// </summary>
        public uint OverallStatusInactiveCount { get; set; }
        /// <summary>
        /// WMI Property OverallStatusNotSupportedCount
        /// </summary>
        public uint OverallStatusNotSupportedCount { get; set; }
        /// <summary>
        /// WMI Property OverallStatusNotYetInstalledCount
        /// </summary>
        public uint OverallStatusNotYetInstalledCount { get; set; }
        /// <summary>
        /// WMI Property OverallStatusProtectedCount
        /// </summary>
        public uint OverallStatusProtectedCount { get; set; }
        /// <summary>
        /// WMI Property SignaturesOlderThan7DaysCount
        /// </summary>
        public uint SignaturesOlderThan7DaysCount { get; set; }
        /// <summary>
        /// WMI Property SignaturesUpTo1DayOldCount
        /// </summary>
        public uint SignaturesUpTo1DayOldCount { get; set; }
        /// <summary>
        /// WMI Property SignaturesUpTo3DaysOldCount
        /// </summary>
        public uint SignaturesUpTo3DaysOldCount { get; set; }
        /// <summary>
        /// WMI Property SignaturesUpTo7DaysOldCount
        /// </summary>
        public uint SignaturesUpTo7DaysOldCount { get; set; }
        /// <summary>
        /// WMI Property TimeLastUpdated
        /// </summary>
        public DateTime TimeLastUpdated { get; set; }
        /// <summary>
        /// WMI Property TotalMemberCount
        /// </summary>
        public uint TotalMemberCount { get; set; }
        /// <summary>
        /// WMI Property TotalOperationalIssueCount
        /// </summary>
        public uint TotalOperationalIssueCount { get; set; }
        /// <summary>
        /// WMI Property UnhealthyCount
        /// </summary>
        public uint UnhealthyCount { get; set; }
    }
}
