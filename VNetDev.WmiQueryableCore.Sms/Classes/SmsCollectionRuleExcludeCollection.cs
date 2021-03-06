using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionRuleExcludeCollection
    /// </summary>
    [WmiClass(Name = "SMS_CollectionRuleExcludeCollection")]
    public class SmsCollectionRuleExcludeCollection
    {
        /// <summary>
        /// WMI Property ExcludeCollectionID
        /// </summary>
        public string ExcludeCollectionId { get; set; }
        /// <summary>
        /// WMI Property RuleName
        /// </summary>
        public string RuleName { get; set; }
    }
}
