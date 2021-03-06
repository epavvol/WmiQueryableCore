using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SiteToSubSite_a
    /// </summary>
    [WmiClass(Name = "SMS_SiteToSubSite_a")]
    public class SmsSiteToSubSiteA
    {
        /// <summary>
        /// WMI Property childSite
        /// </summary>
        public object ChildSite { get; set; }
        /// <summary>
        /// WMI Property parentSite
        /// </summary>
        public object ParentSite { get; set; }
    }
}
