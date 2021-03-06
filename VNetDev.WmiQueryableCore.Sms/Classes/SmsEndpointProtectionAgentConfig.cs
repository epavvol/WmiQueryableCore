using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EndpointProtectionAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_EndpointProtectionAgentConfig")]
    public class SmsEndpointProtectionAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property DisableFirstSignatureUpdate
        /// </summary>
        public bool DisableFirstSignatureUpdate { get; set; }
        /// <summary>
        /// WMI Property EnableBlueProvider
        /// </summary>
        public bool EnableBlueProvider { get; set; }
        /// <summary>
        /// WMI Property EnableEP
        /// </summary>
        public bool EnableEp { get; set; }
        /// <summary>
        /// WMI Property ForceRebootPeriod
        /// </summary>
        public uint ForceRebootPeriod { get; set; }
        /// <summary>
        /// WMI Property InstallRetryPeriod
        /// </summary>
        public uint InstallRetryPeriod { get; set; }
        /// <summary>
        /// WMI Property InstallSCEPClient
        /// </summary>
        public bool InstallScepClient { get; set; }
        /// <summary>
        /// WMI Property LicenseAgreed
        /// </summary>
        public bool LicenseAgreed { get; set; }
        /// <summary>
        /// WMI Property OverrideMaintenanceWindow
        /// </summary>
        public bool OverrideMaintenanceWindow { get; set; }
        /// <summary>
        /// WMI Property PersistInstallation
        /// </summary>
        public bool PersistInstallation { get; set; }
        /// <summary>
        /// WMI Property PolicyEnforcePeriod
        /// </summary>
        public uint PolicyEnforcePeriod { get; set; }
        /// <summary>
        /// WMI Property Remove3rdParty
        /// </summary>
        public bool Remove3rdParty { get; set; }
        /// <summary>
        /// WMI Property SuppressReboot
        /// </summary>
        public bool SuppressReboot { get; set; }
    }
}
