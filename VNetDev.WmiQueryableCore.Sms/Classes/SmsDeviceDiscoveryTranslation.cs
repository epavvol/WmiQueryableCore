using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceDiscoveryTranslation
    /// </summary>
    [WmiClass(Name = "SMS_DeviceDiscoveryTranslation")]
    public class SmsDeviceDiscoveryTranslation
    {
        /// <summary>
        /// WMI Property Item
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// WMI Property Translation
        /// </summary>
        public string Translation { get; set; }
    }
}
