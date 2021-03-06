using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PowerAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_PowerAgentConfig")]
    public class SmsPowerAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property AllowUserToOptOutFromPowerPlan
        /// </summary>
        public bool AllowUserToOptOutFromPowerPlan { get; set; }
        /// <summary>
        /// WMI Property AllowWakeup
        /// </summary>
        public uint AllowWakeup { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property EnableP2PWakeupSolution
        /// </summary>
        public bool EnableP2pWakeupSolution { get; set; }
        /// <summary>
        /// WMI Property EnableUserIdleMonitoring
        /// </summary>
        public bool EnableUserIdleMonitoring { get; set; }
        /// <summary>
        /// WMI Property EnableWakeupProxy
        /// </summary>
        public bool EnableWakeupProxy { get; set; }
        /// <summary>
        /// WMI Property MaxCPU
        /// </summary>
        public uint MaxCpu { get; set; }
        /// <summary>
        /// WMI Property MaxMachinesPerManager
        /// </summary>
        public uint MaxMachinesPerManager { get; set; }
        /// <summary>
        /// WMI Property MinimumServersNeeded
        /// </summary>
        public uint MinimumServersNeeded { get; set; }
        /// <summary>
        /// WMI Property NumOfDaysToKeep
        /// </summary>
        public uint NumOfDaysToKeep { get; set; }
        /// <summary>
        /// WMI Property NumOfMonthsToKeep
        /// </summary>
        public uint NumOfMonthsToKeep { get; set; }
        /// <summary>
        /// WMI Property Port
        /// </summary>
        public uint Port { get; set; }
        /// <summary>
        /// WMI Property WakeupProxyDirectAccessPrefixList
        /// </summary>
        public string WakeupProxyDirectAccessPrefixList { get; set; }
        /// <summary>
        /// WMI Property WakeupProxyFirewallFlags
        /// </summary>
        public uint WakeupProxyFirewallFlags { get; set; }
        /// <summary>
        /// WMI Property WolPort
        /// </summary>
        public uint WolPort { get; set; }
    }
}
