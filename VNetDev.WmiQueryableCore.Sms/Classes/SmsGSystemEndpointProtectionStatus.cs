using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_EndpointProtectionStatus
    /// </summary>
    [WmiClass(Name = "SMS_G_System_EndpointProtectionStatus")]
    public class SmsGSystemEndpointProtectionStatus
    {
        /// <summary>
        /// WMI Property AmFullscanRequired
        /// </summary>
        public bool AmFullscanRequired { get; set; }
        /// <summary>
        /// WMI Property AmManualStepsRequired
        /// </summary>
        public bool AmManualStepsRequired { get; set; }
        /// <summary>
        /// WMI Property AmOfflineScanRequired
        /// </summary>
        public bool AmOfflineScanRequired { get; set; }
        /// <summary>
        /// WMI Property AmRecentlyCleaned
        /// </summary>
        public bool AmRecentlyCleaned { get; set; }
        /// <summary>
        /// WMI Property AmRemediationFailed
        /// </summary>
        public bool AmRemediationFailed { get; set; }
        /// <summary>
        /// WMI Property AmRestartRequired
        /// </summary>
        public bool AmRestartRequired { get; set; }
        /// <summary>
        /// WMI Property AmThreatActivity
        /// </summary>
        public bool AmThreatActivity { get; set; }
        /// <summary>
        /// WMI Property AtRisk
        /// </summary>
        public bool AtRisk { get; set; }
        /// <summary>
        /// WMI Property EnforcementFailed
        /// </summary>
        public bool EnforcementFailed { get; set; }
        /// <summary>
        /// WMI Property EnforcementSucceeded
        /// </summary>
        public bool EnforcementSucceeded { get; set; }
        /// <summary>
        /// WMI Property Inactive
        /// </summary>
        public bool Inactive { get; set; }
        /// <summary>
        /// WMI Property InstallFailed
        /// </summary>
        public bool InstallFailed { get; set; }
        /// <summary>
        /// WMI Property NoSignature
        /// </summary>
        public bool NoSignature { get; set; }
        /// <summary>
        /// WMI Property NotClient
        /// </summary>
        public bool NotClient { get; set; }
        /// <summary>
        /// WMI Property NotYetInstalled
        /// </summary>
        public bool NotYetInstalled { get; set; }
        /// <summary>
        /// WMI Property PendingReboot
        /// </summary>
        public bool PendingReboot { get; set; }
        /// <summary>
        /// WMI Property Protected
        /// </summary>
        public bool Protected { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SignatureOlderThan7Days
        /// </summary>
        public bool SignatureOlderThan7Days { get; set; }
        /// <summary>
        /// WMI Property SignatureUpTo1DayOld
        /// </summary>
        public bool SignatureUpTo1DayOld { get; set; }
        /// <summary>
        /// WMI Property SignatureUpTo3DaysOld
        /// </summary>
        public bool SignatureUpTo3DaysOld { get; set; }
        /// <summary>
        /// WMI Property SignatureUpTo7DaysOld
        /// </summary>
        public bool SignatureUpTo7DaysOld { get; set; }
        /// <summary>
        /// WMI Property Unhealthy
        /// </summary>
        public bool Unhealthy { get; set; }
        /// <summary>
        /// WMI Property Unsupported
        /// </summary>
        public bool Unsupported { get; set; }
    }
}
