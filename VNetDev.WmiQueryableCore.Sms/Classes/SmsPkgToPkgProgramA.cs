using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PkgToPkgProgram_a
    /// </summary>
    [WmiClass(Name = "SMS_PkgToPkgProgram_a")]
    public class SmsPkgToPkgProgramA
    {
        /// <summary>
        /// WMI Property package
        /// </summary>
        public object Package { get; set; }
        /// <summary>
        /// WMI Property pkgProgram
        /// </summary>
        public object PkgProgram { get; set; }
    }
}
