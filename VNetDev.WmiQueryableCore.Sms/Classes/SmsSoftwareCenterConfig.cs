using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SoftwareCenterConfig
    /// </summary>
    [WmiClass(Name = "SMS_SoftwareCenterConfig")]
    public class SmsSoftwareCenterConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property SC_Old_Branding
        /// </summary>
        [WmiProperty(Name = "SC_Old_Branding")]
        public uint ScOldBranding { get; set; }
        /// <summary>
        /// WMI Property SCBrandingColor
        /// </summary>
        public string ScBrandingColor { get; set; }
        /// <summary>
        /// WMI Property SCBrandingString
        /// </summary>
        public string ScBrandingString { get; set; }
        /// <summary>
        /// WMI Property SCLogo
        /// </summary>
        public string ScLogo { get; set; }
        /// <summary>
        /// WMI Property SCShowApplicationsTab
        /// </summary>
        public uint ScShowApplicationsTab { get; set; }
        /// <summary>
        /// WMI Property SCShowComplianceTab
        /// </summary>
        public uint ScShowComplianceTab { get; set; }
        /// <summary>
        /// WMI Property SCShowInstallationTab
        /// </summary>
        public uint ScShowInstallationTab { get; set; }
        /// <summary>
        /// WMI Property SCShowOptionsTab
        /// </summary>
        public uint ScShowOptionsTab { get; set; }
        /// <summary>
        /// WMI Property SCShowOSDTab
        /// </summary>
        public uint ScShowOsdTab { get; set; }
        /// <summary>
        /// WMI Property SCShowUpdatesTab
        /// </summary>
        public uint ScShowUpdatesTab { get; set; }
        /// <summary>
        /// WMI Property SettingsXml
        /// </summary>
        public string SettingsXml { get; set; }
    }
}
