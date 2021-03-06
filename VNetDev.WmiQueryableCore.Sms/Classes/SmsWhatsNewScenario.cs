using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WhatsNewScenario
    /// </summary>
    [WmiClass(Name = "SMS_WhatsNewScenario")]
    public class SmsWhatsNewScenario
    {
        /// <summary>
        /// WMI Property Completed
        /// </summary>
        public bool Completed { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
