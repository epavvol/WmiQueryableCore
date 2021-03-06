using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CommonMacAddresses
    /// </summary>
    [WmiClass(Name = "SMS_CommonMacAddresses")]
    public class SmsCommonMacAddresses
    {
        /// <summary>
        /// WMI Property MACAddress
        /// </summary>
        public string MacAddress { get; set; }
    }
}
