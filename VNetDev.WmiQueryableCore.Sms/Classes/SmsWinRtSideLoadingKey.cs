using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_WinRTSideLoadingKey
    /// </summary>
    [WmiClass(Name = "SMS_WinRTSideLoadingKey")]
    public class SmsWinRtSideLoadingKey
    {
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property KeyId
        /// </summary>
        public uint KeyId { get; set; }
        /// <summary>
        /// WMI Property LicenseKey
        /// </summary>
        public string LicenseKey { get; set; }
        /// <summary>
        /// WMI Property MaxActivationCount
        /// </summary>
        public uint MaxActivationCount { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property UsedCount
        /// </summary>
        public uint UsedCount { get; set; }
    }
}
