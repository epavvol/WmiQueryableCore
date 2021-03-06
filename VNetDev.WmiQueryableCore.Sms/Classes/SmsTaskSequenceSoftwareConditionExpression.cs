using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_SoftwareConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_SoftwareConditionExpression")]
    public class SmsTaskSequenceSoftwareConditionExpression
    {
        /// <summary>
        /// WMI Property Operator
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// WMI Property ProductCode
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property UpgradeCode
        /// </summary>
        public string UpgradeCode { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
