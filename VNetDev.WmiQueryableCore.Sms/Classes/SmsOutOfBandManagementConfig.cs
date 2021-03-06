using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OutOfBandManagementConfig
    /// </summary>
    [WmiClass(Name = "SMS_OutOfBandManagementConfig")]
    public class SmsOutOfBandManagementConfig
    {
        /// <summary>
        /// WMI Property ACLlist
        /// </summary>
        public ICollection<string> AcLlist { get; set; }
        /// <summary>
        /// WMI Property ActiveDirectoryContainer
        /// </summary>
        public string ActiveDirectoryContainer { get; set; }
        /// <summary>
        /// WMI Property ActiveDirectorySecurityGroup
        /// </summary>
        public string ActiveDirectorySecurityGroup { get; set; }
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property Auditlogsettings
        /// </summary>
        public ICollection<string> Auditlogsettings { get; set; }
        /// <summary>
        /// WMI Property Certificatetemplate
        /// </summary>
        public string Certificatetemplate { get; set; }
        /// <summary>
        /// WMI Property EnablePing
        /// </summary>
        public bool EnablePing { get; set; }
        /// <summary>
        /// WMI Property EnableSOL
        /// </summary>
        public bool EnableSol { get; set; }
        /// <summary>
        /// WMI Property EnableWebUI
        /// </summary>
        public bool EnableWebUi { get; set; }
        /// <summary>
        /// WMI Property Kerberosclocktolerance
        /// </summary>
        public uint Kerberosclocktolerance { get; set; }
        /// <summary>
        /// WMI Property PowerStatePolicy
        /// </summary>
        public uint PowerStatePolicy { get; set; }
        /// <summary>
        /// WMI Property WiredProfile
        /// </summary>
        public string WiredProfile { get; set; }
        /// <summary>
        /// WMI Property WirelessProfiles
        /// </summary>
        public ICollection<string> WirelessProfiles { get; set; }
    }
}
