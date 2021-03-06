using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_MakeModelConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_MakeModelConditionExpression")]
    public class SmsTaskSequenceMakeModelConditionExpression
    {
        /// <summary>
        /// WMI Property Make
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
    }
}
