using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UserApplicationRequestHistoryItem
    /// </summary>
    [WmiClass(Name = "SMS_UserApplicationRequestHistoryItem")]
    public class SmsUserApplicationRequestHistoryItem
    {
        /// <summary>
        /// WMI Property Comments
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ModifiedDate
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
