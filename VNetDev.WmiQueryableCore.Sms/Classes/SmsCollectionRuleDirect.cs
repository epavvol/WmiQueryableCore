using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionRuleDirect
    /// </summary>
    [WmiClass(Name = "SMS_CollectionRuleDirect")]
    public class SmsCollectionRuleDirect
    {
        /// <summary>
        /// WMI Property ResourceClassName
        /// </summary>
        public string ResourceClassName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RuleName
        /// </summary>
        public string RuleName { get; set; }
    }
}
