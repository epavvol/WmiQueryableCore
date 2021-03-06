using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionRule
    /// </summary>
    [WmiClass(Name = "SMS_CollectionRule")]
    public class SmsCollectionRule
    {
        /// <summary>
        /// WMI Property RuleName
        /// </summary>
        public string RuleName { get; set; }
    }
}
