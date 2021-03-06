using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdminCategory
    /// </summary>
    [WmiClass(Name = "SMS_AdminCategory")]
    public class SmsAdminCategory
    {
        /// <summary>
        /// WMI Property AdminID
        /// </summary>
        public uint AdminId { get; set; }
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public string CategoryId { get; set; }
    }
}
