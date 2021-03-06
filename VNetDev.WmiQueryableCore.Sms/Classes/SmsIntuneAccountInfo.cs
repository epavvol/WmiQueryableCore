using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_IntuneAccountInfo
    /// </summary>
    [WmiClass(Name = "SMS_IntuneAccountInfo")]
    public class SmsIntuneAccountInfo
    {
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property IntuneAccountID
        /// </summary>
        public string IntuneAccountId { get; set; }
        /// <summary>
        /// WMI Property IntuneResourceID
        /// </summary>
        public string IntuneResourceId { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
    }
}
