using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConfigMgrClientAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_ConfigMgrClientAgentConfig")]
    public class SmsConfigMgrClientAgentConfig
    {
        /// <summary>
        /// WMI Property AddPortalToTrustedSiteList
        /// </summary>
        public bool AddPortalToTrustedSiteList { get; set; }
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property AllowPortalToHaveElevatedTrust
        /// </summary>
        public bool AllowPortalToHaveElevatedTrust { get; set; }
        /// <summary>
        /// WMI Property BrandingTitle
        /// </summary>
        public string BrandingTitle { get; set; }
        /// <summary>
        /// WMI Property DayReminderInterval
        /// </summary>
        public uint DayReminderInterval { get; set; }
        /// <summary>
        /// WMI Property DevicesHealthCollectionEnabled
        /// </summary>
        public uint DevicesHealthCollectionEnabled { get; set; }
        /// <summary>
        /// WMI Property DisplayNewProgramNotification
        /// </summary>
        public bool DisplayNewProgramNotification { get; set; }
        /// <summary>
        /// WMI Property EnableHealthAttestation
        /// </summary>
        public bool EnableHealthAttestation { get; set; }
        /// <summary>
        /// WMI Property EnableThirdPartyOrchestration
        /// </summary>
        public uint EnableThirdPartyOrchestration { get; set; }
        /// <summary>
        /// WMI Property GracePeriodHours
        /// </summary>
        public uint GracePeriodHours { get; set; }
        /// <summary>
        /// WMI Property HourReminderInterval
        /// </summary>
        public uint HourReminderInterval { get; set; }
        /// <summary>
        /// WMI Property InstallRestriction
        /// </summary>
        public uint InstallRestriction { get; set; }
        /// <summary>
        /// WMI Property OnPremHAServiceUrl
        /// </summary>
        public string OnPremHaServiceUrl { get; set; }
        /// <summary>
        /// WMI Property OSDBrandingSubTitle
        /// </summary>
        public string OsdBrandingSubTitle { get; set; }
        /// <summary>
        /// WMI Property PortalUrl
        /// </summary>
        public string PortalUrl { get; set; }
        /// <summary>
        /// WMI Property PowerShellExecutionPolicy
        /// </summary>
        public uint PowerShellExecutionPolicy { get; set; }
        /// <summary>
        /// WMI Property ReminderInterval
        /// </summary>
        public uint ReminderInterval { get; set; }
        /// <summary>
        /// WMI Property SUMBrandingSubTitle
        /// </summary>
        public string SumBrandingSubTitle { get; set; }
        /// <summary>
        /// WMI Property SuspendBitLocker
        /// </summary>
        public uint SuspendBitLocker { get; set; }
        /// <summary>
        /// WMI Property SWDBrandingSubTitle
        /// </summary>
        public string SwdBrandingSubTitle { get; set; }
        /// <summary>
        /// WMI Property SystemRestartTurnaroundTime
        /// </summary>
        public uint SystemRestartTurnaroundTime { get; set; }
        /// <summary>
        /// WMI Property UseNewSoftwareCenter
        /// </summary>
        public bool UseNewSoftwareCenter { get; set; }
        /// <summary>
        /// WMI Property UseOnPremHAService
        /// </summary>
        public bool UseOnPremHaService { get; set; }
    }
}
