using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ApplicationManagementAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_ApplicationManagementAgentConfig")]
    public class SmsApplicationManagementAgentConfig
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
        /// WMI Property AppXInplaceUpgradeEnabled
        /// </summary>
        public bool AppXInplaceUpgradeEnabled { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EvaluationSchedule
        /// </summary>
        public string EvaluationSchedule { get; set; }
    }
}
