using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SetupInfo
    /// </summary>
    [WmiClass(Name = "SMS_SetupInfo")]
    public class SmsSetupInfo
    {
        /// <summary>
        /// WMI Property id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property String1
        /// </summary>
        public string String1 { get; set; }
        /// <summary>
        /// WMI Property String2
        /// </summary>
        public string String2 { get; set; }
        /// <summary>
        /// WMI Property Value1
        /// </summary>
        public int Value1 { get; set; }
        /// <summary>
        /// WMI Property Value2
        /// </summary>
        public int Value2 { get; set; }
    }
}
