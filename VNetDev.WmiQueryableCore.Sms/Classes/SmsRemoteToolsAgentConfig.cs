using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_RemoteToolsAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_RemoteToolsAgentConfig")]
    public class SmsRemoteToolsAgentConfig
    {
        /// <summary>
        /// WMI Property AccessLevel
        /// </summary>
        public uint AccessLevel { get; set; }
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property AllowClientChange
        /// </summary>
        public bool AllowClientChange { get; set; }
        /// <summary>
        /// WMI Property AllowLocalAdminToDoRemoteControl
        /// </summary>
        public bool AllowLocalAdminToDoRemoteControl { get; set; }
        /// <summary>
        /// WMI Property AllowRAUnsolicitedControl
        /// </summary>
        public bool AllowRaUnsolicitedControl { get; set; }
        /// <summary>
        /// WMI Property AllowRAUnsolicitedView
        /// </summary>
        public bool AllowRaUnsolicitedView { get; set; }
        /// <summary>
        /// WMI Property AllowRemCtrlToUnattended
        /// </summary>
        public bool AllowRemCtrlToUnattended { get; set; }
        /// <summary>
        /// WMI Property AudibleSignal
        /// </summary>
        public uint AudibleSignal { get; set; }
        /// <summary>
        /// WMI Property ClipboardAccessPermissionRequired
        /// </summary>
        public bool ClipboardAccessPermissionRequired { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnableRA
        /// </summary>
        public bool EnableRa { get; set; }
        /// <summary>
        /// WMI Property EnableTS
        /// </summary>
        public bool EnableTs { get; set; }
        /// <summary>
        /// WMI Property EnforceRAandTSSettings
        /// </summary>
        public bool EnforceRAandTsSettings { get; set; }
        /// <summary>
        /// WMI Property FirewallExceptionProfiles
        /// </summary>
        public uint FirewallExceptionProfiles { get; set; }
        /// <summary>
        /// WMI Property ManageRA
        /// </summary>
        public bool ManageRa { get; set; }
        /// <summary>
        /// WMI Property ManageTS
        /// </summary>
        public bool ManageTs { get; set; }
        /// <summary>
        /// WMI Property PermissionRequired
        /// </summary>
        public bool PermissionRequired { get; set; }
        /// <summary>
        /// WMI Property PermittedViewers
        /// </summary>
        public ICollection<string> PermittedViewers { get; set; }
        /// <summary>
        /// WMI Property RemCtrlConnectionBar
        /// </summary>
        public bool RemCtrlConnectionBar { get; set; }
        /// <summary>
        /// WMI Property RemCtrlTaskbarIcon
        /// </summary>
        public bool RemCtrlTaskbarIcon { get; set; }
        /// <summary>
        /// WMI Property TSUserAuthentication
        /// </summary>
        public bool TsUserAuthentication { get; set; }
    }
}
