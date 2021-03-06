using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CI_LocalizedEulas
    /// </summary>
    [WmiClass(Name = "SMS_CI_LocalizedEulas")]
    public class SmsCiLocalizedEulas
    {
        /// <summary>
        /// WMI Property EULAContentUniqueID
        /// </summary>
        public string EulaContentUniqueId { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public uint LocaleId { get; set; }
    }
}
