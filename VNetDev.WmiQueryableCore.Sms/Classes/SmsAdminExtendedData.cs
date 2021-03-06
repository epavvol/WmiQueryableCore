using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdminExtendedData
    /// </summary>
    [WmiClass(Name = "SMS_AdminExtendedData")]
    public class SmsAdminExtendedData
    {
        /// <summary>
        /// WMI Property Data
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
