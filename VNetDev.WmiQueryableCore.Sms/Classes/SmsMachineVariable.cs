using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MachineVariable
    /// </summary>
    [WmiClass(Name = "SMS_MachineVariable")]
    public class SmsMachineVariable
    {
        /// <summary>
        /// WMI Property IsMasked
        /// </summary>
        public bool IsMasked { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
