using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdvertToSourceSite_a
    /// </summary>
    [WmiClass(Name = "SMS_AdvertToSourceSite_a")]
    public class SmsAdvertToSourceSiteA
    {
        /// <summary>
        /// WMI Property advertSourceSite
        /// </summary>
        public object AdvertSourceSite { get; set; }
        /// <summary>
        /// WMI Property ownedAdvert
        /// </summary>
        public object OwnedAdvert { get; set; }
    }
}
