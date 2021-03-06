using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientCommunicationConfig
    /// </summary>
    [WmiClass(Name = "SMS_ClientCommunicationConfig")]
    public class SmsClientCommunicationConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property MeteredNetworkUsage
        /// </summary>
        public uint MeteredNetworkUsage { get; set; }
    }
}
