using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionRuleIncludeCollection
    /// </summary>
    [WmiClass(Name = "SMS_CollectionRuleIncludeCollection")]
    public class SmsCollectionRuleIncludeCollection
    {
        /// <summary>
        /// WMI Property IncludeCollectionID
        /// </summary>
        public string IncludeCollectionId { get; set; }
        /// <summary>
        /// WMI Property RuleName
        /// </summary>
        public string RuleName { get; set; }
    }
}
