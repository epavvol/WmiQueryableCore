using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MeteredUser
    /// </summary>
    [WmiClass(Name = "SMS_MeteredUser")]
    public class SmsMeteredUser
    {
        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// WMI Property FullName
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// WMI Property MeteredUserID
        /// </summary>
        public uint MeteredUserId { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
