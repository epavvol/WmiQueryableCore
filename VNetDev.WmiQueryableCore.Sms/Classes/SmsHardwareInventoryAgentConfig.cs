using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_HardwareInventoryAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_HardwareInventoryAgentConfig")]
    public class SmsHardwareInventoryAgentConfig
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
        /// WMI Property InventoryReportID
        /// </summary>
        public string InventoryReportId { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public string LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property Max3rdPartyMIFSize
        /// </summary>
        public uint Max3rdPartyMifSize { get; set; }
        /// <summary>
        /// WMI Property MaxRandomDelayMinutes
        /// </summary>
        public uint MaxRandomDelayMinutes { get; set; }
        /// <summary>
        /// WMI Property MIFCollection
        /// </summary>
        public uint MifCollection { get; set; }
        /// <summary>
        /// WMI Property ProviderTimeout
        /// </summary>
        public uint ProviderTimeout { get; set; }
        /// <summary>
        /// WMI Property Schedule
        /// </summary>
        public string Schedule { get; set; }
    }
}
