using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CH_Settings
    /// </summary>
    [WmiClass(Name = "SMS_CH_Settings")]
    public class SmsChSettings
    {
        /// <summary>
        /// WMI Property ADRetrievingSchedule
        /// </summary>
        public string AdRetrievingSchedule { get; set; }
        /// <summary>
        /// WMI Property CleanUpInterval
        /// </summary>
        public uint CleanUpInterval { get; set; }
        /// <summary>
        /// WMI Property DDRInactiveInterval
        /// </summary>
        public uint DdrInactiveInterval { get; set; }
        /// <summary>
        /// WMI Property HWInactiveInterval
        /// </summary>
        public uint HwInactiveInterval { get; set; }
        /// <summary>
        /// WMI Property NeedADLastLogonTime
        /// </summary>
        public bool NeedAdLastLogonTime { get; set; }
        /// <summary>
        /// WMI Property PolicyInactiveInterval
        /// </summary>
        public uint PolicyInactiveInterval { get; set; }
        /// <summary>
        /// WMI Property SettingsID
        /// </summary>
        public uint SettingsId { get; set; }
        /// <summary>
        /// WMI Property StatusInactiveInterval
        /// </summary>
        public uint StatusInactiveInterval { get; set; }
        /// <summary>
        /// WMI Property SWInactiveInterval
        /// </summary>
        public uint SwInactiveInterval { get; set; }
    }
}
