using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CustomConfigurationSettingsSettings
    /// </summary>
    [WmiClass(Name = "SMS_CustomConfigurationSettingsSettings")]
    public class SmsCustomConfigurationSettingsSettings
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property DataType
        /// </summary>
        public uint DataType { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property Setting_ID
        /// </summary>
        [WmiProperty(Name = "Setting_ID")]
        public uint SettingId { get; set; }
        /// <summary>
        /// WMI Property Setting_UniqueID
        /// </summary>
        [WmiProperty(Name = "Setting_UniqueID")]
        public string SettingUniqueId { get; set; }
        /// <summary>
        /// WMI Property SettingDescription
        /// </summary>
        public string SettingDescription { get; set; }
        /// <summary>
        /// WMI Property SettingName
        /// </summary>
        public string SettingName { get; set; }
        /// <summary>
        /// WMI Property SourceType
        /// </summary>
        public uint SourceType { get; set; }
    }
}
