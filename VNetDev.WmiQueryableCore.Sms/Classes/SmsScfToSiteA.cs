using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCFToSite_a
    /// </summary>
    [WmiClass(Name = "SMS_SCFToSite_a")]
    public class SmsScfToSiteA
    {
        /// <summary>
        /// WMI Property Site
        /// </summary>
        public object Site { get; set; }
        /// <summary>
        /// WMI Property SiteControlFile
        /// </summary>
        public object SiteControlFile { get; set; }
    }
}
