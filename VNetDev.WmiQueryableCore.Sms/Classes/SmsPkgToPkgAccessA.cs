using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PkgToPkgAccess_a
    /// </summary>
    [WmiClass(Name = "SMS_PkgToPkgAccess_a")]
    public class SmsPkgToPkgAccessA
    {
        /// <summary>
        /// WMI Property package
        /// </summary>
        public object Package { get; set; }
        /// <summary>
        /// WMI Property pkgAccess
        /// </summary>
        public object PkgAccess { get; set; }
    }
}
