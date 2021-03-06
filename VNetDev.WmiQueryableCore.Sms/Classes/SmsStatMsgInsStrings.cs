using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StatMsgInsStrings
    /// </summary>
    [WmiClass(Name = "SMS_StatMsgInsStrings")]
    public class SmsStatMsgInsStrings
    {
        /// <summary>
        /// WMI Property InsStrIndex
        /// </summary>
        public uint InsStrIndex { get; set; }
        /// <summary>
        /// WMI Property InsStrValue
        /// </summary>
        public string InsStrValue { get; set; }
        /// <summary>
        /// WMI Property RecordID
        /// </summary>
        public long RecordId { get; set; }
    }
}
