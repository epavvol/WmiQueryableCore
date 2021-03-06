using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_Condition
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_Condition")]
    public class SmsTaskSequenceCondition
    {
        /// <summary>
        /// WMI Property Operands
        /// </summary>
        public ICollection<object> Operands { get; set; }
    }
}
