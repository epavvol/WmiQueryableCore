using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ConditionOperator
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ConditionOperator")]
    public class SmsTaskSequenceConditionOperator
    {
        /// <summary>
        /// WMI Property Operands
        /// </summary>
        public ICollection<object> Operands { get; set; }
        /// <summary>
        /// WMI Property OperatorType
        /// </summary>
        public string OperatorType { get; set; }
    }
}
