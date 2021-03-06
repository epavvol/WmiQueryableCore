using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteToSiteID_a
    /// </summary>
    [WmiClass(Name = "SMS_SiteToSiteID_a")]
    public class SmsSiteToSiteIdA
    {
        /// <summary>
        /// WMI Property site
        /// </summary>
        public object Site { get; set; }
        /// <summary>
        /// WMI Property siteIdentification
        /// </summary>
        public object SiteIdentification { get; set; }
    }
}
