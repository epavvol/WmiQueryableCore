using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceSettingPackageItem
    /// </summary>
    [WmiClass(Name = "SMS_DeviceSettingPackageItem")]
    public class SmsDeviceSettingPackageItem
    {
        /// <summary>
        /// WMI Property DeviceSettingItemUniqueID
        /// </summary>
        public string DeviceSettingItemUniqueId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
    }
}
