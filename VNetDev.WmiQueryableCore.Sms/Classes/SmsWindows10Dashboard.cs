using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Windows10Dashboard
    /// </summary>
    [WmiClass(Name = "SMS_Windows10Dashboard")]
    public class SmsWindows10Dashboard
    {
        /// <summary>
        /// WMI Property Branch
        /// </summary>
        public string Branch { get; set; }
        /// <summary>
        /// WMI Property Build
        /// </summary>
        public string Build { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumClients
        /// </summary>
        public uint NumClients { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
