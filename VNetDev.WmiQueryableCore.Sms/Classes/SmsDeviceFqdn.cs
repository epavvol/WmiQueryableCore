using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceFQDN
    /// </summary>
    [WmiClass(Name = "SMS_DeviceFQDN")]
    public class SmsDeviceFqdn
    {
        /// <summary>
        /// WMI Property FQDN
        /// </summary>
        public string Fqdn { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
    }
}
