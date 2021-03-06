using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PkgToPkgServer_a
    /// </summary>
    [WmiClass(Name = "SMS_PkgToPkgServer_a")]
    public class SmsPkgToPkgServerA
    {
        /// <summary>
        /// WMI Property package
        /// </summary>
        public object Package { get; set; }
        /// <summary>
        /// WMI Property pkgServer
        /// </summary>
        public object PkgServer { get; set; }
    }
}
