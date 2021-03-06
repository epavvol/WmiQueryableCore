using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ApplyWindowsSettingsAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ApplyWindowsSettingsAction")]
    public class SmsTaskSequenceApplyWindowsSettingsAction
    {
        /// <summary>
        /// WMI Property AdminPassword
        /// </summary>
        public string AdminPassword { get; set; }
        /// <summary>
        /// WMI Property ComputerName
        /// </summary>
        public string ComputerName { get; set; }
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property InputLocale
        /// </summary>
        public string InputLocale { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ProductKey
        /// </summary>
        public string ProductKey { get; set; }
        /// <summary>
        /// WMI Property RandomAdminPassword
        /// </summary>
        public bool RandomAdminPassword { get; set; }
        /// <summary>
        /// WMI Property RegisteredOrgName
        /// </summary>
        public string RegisteredOrgName { get; set; }
        /// <summary>
        /// WMI Property RegisteredUserName
        /// </summary>
        public string RegisteredUserName { get; set; }
        /// <summary>
        /// WMI Property ServerLicenseConnectionLimit
        /// </summary>
        public uint ServerLicenseConnectionLimit { get; set; }
        /// <summary>
        /// WMI Property ServerLicenseMode
        /// </summary>
        public string ServerLicenseMode { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property SystemLocale
        /// </summary>
        public string SystemLocale { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
        /// <summary>
        /// WMI Property TimeZone
        /// </summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// WMI Property UILanguage
        /// </summary>
        public string UiLanguage { get; set; }
        /// <summary>
        /// WMI Property UILanguageFallback
        /// </summary>
        public string UiLanguageFallback { get; set; }
        /// <summary>
        /// WMI Property UserLocale
        /// </summary>
        public string UserLocale { get; set; }
    }
}
