using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_RegistryConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_RegistryConditionExpression")]
    public class SmsTaskSequenceRegistryConditionExpression
    {
        /// <summary>
        /// WMI Property Data
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// WMI Property KeyPath
        /// </summary>
        public string KeyPath { get; set; }
        /// <summary>
        /// WMI Property Operator
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
