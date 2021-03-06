using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_EULAContent
    /// </summary>
    [WmiClass(Name = "SMS_EULAContent")]
    public class SmsEulaContent
    {
        /// <summary>
        /// WMI Property EULAContentID
        /// </summary>
        public uint EulaContentId { get; set; }
        /// <summary>
        /// WMI Property EULAContentUniqueID
        /// </summary>
        public string EulaContentUniqueId { get; set; }
        /// <summary>
        /// WMI Property EULAText
        /// </summary>
        public string EulaText { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
    }
}
