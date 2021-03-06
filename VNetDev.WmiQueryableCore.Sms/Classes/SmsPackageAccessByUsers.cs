using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageAccessByUsers
    /// </summary>
    [WmiClass(Name = "SMS_PackageAccessByUsers")]
    public class SmsPackageAccessByUsers
    {
        /// <summary>
        /// WMI Property Access
        /// </summary>
        public uint Access { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
