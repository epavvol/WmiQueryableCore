using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SupportedPlatformsOfflineServicing
    /// </summary>
    [WmiClass(Name = "SMS_SupportedPlatformsOfflineServicing")]
    public class SmsSupportedPlatformsOfflineServicing
    {
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OsVersionBuild
        /// </summary>
        public string OsVersionBuild { get; set; }
        /// <summary>
        /// WMI Property ProductType
        /// </summary>
        public string ProductType { get; set; }
    }
}
