using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ApplicationCondition
    /// </summary>
    [WmiClass(Name = "SMS_ApplicationCondition")]
    public class SmsApplicationCondition
    {
        /// <summary>
        /// WMI Property ApplicationGUID
        /// </summary>
        public string ApplicationGuid { get; set; }
        /// <summary>
        /// WMI Property ConditionDisplayName
        /// </summary>
        public string ConditionDisplayName { get; set; }
        /// <summary>
        /// WMI Property ConditionID
        /// </summary>
        public uint ConditionId { get; set; }
        /// <summary>
        /// WMI Property ConditionModelName
        /// </summary>
        public string ConditionModelName { get; set; }
    }
}
