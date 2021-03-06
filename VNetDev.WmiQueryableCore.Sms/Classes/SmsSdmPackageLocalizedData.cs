using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SDMPackageLocalizedData
    /// </summary>
    [WmiClass(Name = "SMS_SDMPackageLocalizedData")]
    public class SmsSdmPackageLocalizedData
    {
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
        /// <summary>
        /// WMI Property LocalizedData
        /// </summary>
        public string LocalizedData { get; set; }
    }
}
