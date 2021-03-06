using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientResourcesConfig
    /// </summary>
    [WmiClass(Name = "SMS_ClientResourcesConfig")]
    public class SmsClientResourcesConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property DisableGlobalRandomization
        /// </summary>
        public bool DisableGlobalRandomization { get; set; }
    }
}
