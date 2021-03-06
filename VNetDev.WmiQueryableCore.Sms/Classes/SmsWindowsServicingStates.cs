using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WindowsServicingStates
    /// </summary>
    [WmiClass(Name = "SMS_WindowsServicingStates")]
    public class SmsWindowsServicingStates
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
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
