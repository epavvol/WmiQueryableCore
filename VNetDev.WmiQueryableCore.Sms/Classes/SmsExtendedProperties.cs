using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Extended_Properties
    /// </summary>
    [WmiClass(Name = "SMS_Extended_Properties")]
    public class SmsExtendedProperties
    {
        /// <summary>
        /// WMI Property Property
        /// </summary>
        public string Property { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
