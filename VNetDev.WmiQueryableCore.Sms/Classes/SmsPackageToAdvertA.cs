using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageToAdvert_a
    /// </summary>
    [WmiClass(Name = "SMS_PackageToAdvert_a")]
    public class SmsPackageToAdvertA
    {
        /// <summary>
        /// WMI Property advert
        /// </summary>
        public object Advert { get; set; }
        /// <summary>
        /// WMI Property package
        /// </summary>
        public object Package { get; set; }
    }
}
