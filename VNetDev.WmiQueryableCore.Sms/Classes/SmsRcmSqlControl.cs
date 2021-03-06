using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_RcmSqlControl
    /// </summary>
    [WmiClass(Name = "SMS_RcmSqlControl")]
    public class SmsRcmSqlControl
    {
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public ICollection<SmsRcmSqlControlProperty> Props { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property TypeName
        /// </summary>
        public string TypeName { get; set; }
    }
}
