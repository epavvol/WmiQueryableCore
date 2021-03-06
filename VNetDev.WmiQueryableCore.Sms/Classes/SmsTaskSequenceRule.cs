using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_Rule
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_Rule")]
    public class SmsTaskSequenceRule
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property Variables
        /// </summary>
        public ICollection<object> Variables { get; set; }
    }
}
