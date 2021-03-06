using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionVariable
    /// </summary>
    [WmiClass(Name = "SMS_CollectionVariable")]
    public class SmsCollectionVariable
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
