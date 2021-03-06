using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageToSourceSite_a
    /// </summary>
    [WmiClass(Name = "SMS_PackageToSourceSite_a")]
    public class SmsPackageToSourceSiteA
    {
        /// <summary>
        /// WMI Property ownedPackage
        /// </summary>
        public object OwnedPackage { get; set; }
        /// <summary>
        /// WMI Property pkgSourcesite
        /// </summary>
        public object PkgSourcesite { get; set; }
    }
}
