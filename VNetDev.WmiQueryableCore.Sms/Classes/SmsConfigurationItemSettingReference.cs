using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConfigurationItemSettingReference
    /// </summary>
    [WmiClass(Name = "SMS_ConfigurationItemSettingReference")]
    public class SmsConfigurationItemSettingReference
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property IsBroken
        /// </summary>
        public bool IsBroken { get; set; }
        /// <summary>
        /// WMI Property Rule_ID
        /// </summary>
        [WmiProperty(Name = "Rule_ID")]
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property Setting_ID
        /// </summary>
        [WmiProperty(Name = "Setting_ID")]
        public uint SettingId { get; set; }
        /// <summary>
        /// WMI Property SettingName
        /// </summary>
        public string SettingName { get; set; }
    }
}
