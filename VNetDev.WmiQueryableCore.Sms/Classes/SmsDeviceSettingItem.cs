using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceSettingItem
    /// </summary>
    [WmiClass(Name = "SMS_DeviceSettingItem")]
    public class SmsDeviceSettingItem
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceSettingItemUniqueID
        /// </summary>
        public string DeviceSettingItemUniqueId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PropList
        /// </summary>
        public string PropList { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public uint Version { get; set; }
    }
}
