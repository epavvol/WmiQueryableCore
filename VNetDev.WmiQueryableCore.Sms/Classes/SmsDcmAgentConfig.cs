using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DCMAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_DCMAgentConfig")]
    public class SmsDcmAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnableUserStateManagement
        /// </summary>
        public bool EnableUserStateManagement { get; set; }
        /// <summary>
        /// WMI Property EvaluationSchedule
        /// </summary>
        public string EvaluationSchedule { get; set; }
        /// <summary>
        /// WMI Property PerProviderTimeout
        /// </summary>
        public uint PerProviderTimeout { get; set; }
        /// <summary>
        /// WMI Property PerScanDefaultPriority
        /// </summary>
        public uint PerScanDefaultPriority { get; set; }
        /// <summary>
        /// WMI Property PerScanTimeout
        /// </summary>
        public uint PerScanTimeout { get; set; }
        /// <summary>
        /// WMI Property PerScanTTL
        /// </summary>
        public uint PerScanTtl { get; set; }
    }
}
