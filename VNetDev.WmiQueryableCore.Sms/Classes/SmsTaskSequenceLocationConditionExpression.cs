using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_LocationConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_LocationConditionExpression")]
    public class SmsTaskSequenceLocationConditionExpression
    {
        /// <summary>
        /// WMI Property DefaultGateway
        /// </summary>
        public string DefaultGateway { get; set; }
    }
}
