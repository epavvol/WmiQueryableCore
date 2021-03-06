using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_OSConditionGroup
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_OSConditionGroup")]
    public class SmsTaskSequenceOsConditionGroup
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
