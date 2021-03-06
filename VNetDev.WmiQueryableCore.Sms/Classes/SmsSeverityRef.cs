using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SeverityRef
    /// </summary>
    [WmiClass(Name = "SMS_SeverityRef")]
    public class SmsSeverityRef
    {
        /// <summary>
        /// WMI Property CustomName
        /// </summary>
        public string CustomName { get; set; }
        /// <summary>
        /// WMI Property SeverityID
        /// </summary>
        public uint SeverityId { get; set; }
    }
}
