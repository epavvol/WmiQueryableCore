using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_NetworkAccessAccountConfig
    /// </summary>
    [WmiClass(Name = "SMS_NetworkAccessAccountConfig")]
    public class SmsNetworkAccessAccountConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property SendToAllClients
        /// </summary>
        public bool SendToAllClients { get; set; }
        /// <summary>
        /// WMI Property Username
        /// </summary>
        public string Username { get; set; }
    }
}
