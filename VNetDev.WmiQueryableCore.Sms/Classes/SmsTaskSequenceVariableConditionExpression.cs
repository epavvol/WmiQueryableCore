using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_VariableConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_VariableConditionExpression")]
    public class SmsTaskSequenceVariableConditionExpression
    {
        /// <summary>
        /// WMI Property Operator
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// WMI Property Variable
        /// </summary>
        public string Variable { get; set; }
    }
}
