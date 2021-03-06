using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_WMIConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_WMIConditionExpression")]
    public class SmsTaskSequenceWmiConditionExpression
    {
        /// <summary>
        /// WMI Property Namespace
        /// </summary>
        public string Namespace { get; set; }
        /// <summary>
        /// WMI Property Query
        /// </summary>
        public string Query { get; set; }
    }
}
