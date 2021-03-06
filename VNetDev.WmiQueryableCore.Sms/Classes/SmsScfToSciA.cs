using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCFToSCI_a
    /// </summary>
    [WmiClass(Name = "SMS_SCFToSCI_a")]
    public class SmsScfToSciA
    {
        /// <summary>
        /// WMI Property SiteControlFile
        /// </summary>
        public object SiteControlFile { get; set; }
        /// <summary>
        /// WMI Property SiteControlItem
        /// </summary>
        public object SiteControlItem { get; set; }
    }
}
