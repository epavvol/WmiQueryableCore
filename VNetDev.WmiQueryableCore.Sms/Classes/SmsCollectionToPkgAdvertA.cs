using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionToPkgAdvert_a
    /// </summary>
    [WmiClass(Name = "SMS_CollectionToPkgAdvert_a")]
    public class SmsCollectionToPkgAdvertA
    {
        /// <summary>
        /// WMI Property advert
        /// </summary>
        public object Advert { get; set; }
        /// <summary>
        /// WMI Property collection
        /// </summary>
        public object Collection { get; set; }
    }
}
