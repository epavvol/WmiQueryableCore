using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BigGreenButtonConfig
    /// </summary>
    [WmiClass(Name = "SMS_BigGreenButtonConfig")]
    public class SmsBigGreenButtonConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property EnableClientNotification
        /// </summary>
        public bool EnableClientNotification { get; set; }
    }
}
