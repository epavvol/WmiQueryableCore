using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_ComputerConditionExpression
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_ComputerConditionExpression")]
    public class SmsTaskSequenceComputerConditionExpression
    {
        /// <summary>
        /// WMI Property AssetTag
        /// </summary>
        public string AssetTag { get; set; }
        /// <summary>
        /// WMI Property MACAddress
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property UUID
        /// </summary>
        public string Uuid { get; set; }
    }
}
