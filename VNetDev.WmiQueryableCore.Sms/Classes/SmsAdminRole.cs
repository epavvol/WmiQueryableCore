using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdminRole
    /// </summary>
    [WmiClass(Name = "SMS_AdminRole")]
    public class SmsAdminRole
    {
        /// <summary>
        /// WMI Property AdminID
        /// </summary>
        public uint AdminId { get; set; }
        /// <summary>
        /// WMI Property RoleID
        /// </summary>
        public string RoleId { get; set; }
    }
}
