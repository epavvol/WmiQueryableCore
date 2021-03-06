using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StateInformation
    /// </summary>
    [WmiClass(Name = "SMS_StateInformation")]
    public class SmsStateInformation
    {
        /// <summary>
        /// WMI Property StateDescription
        /// </summary>
        public string StateDescription { get; set; }
        /// <summary>
        /// WMI Property StateID
        /// </summary>
        public uint StateId { get; set; }
        /// <summary>
        /// WMI Property StateName
        /// </summary>
        public string StateName { get; set; }
        /// <summary>
        /// WMI Property TopicType
        /// </summary>
        public uint TopicType { get; set; }
    }
}
