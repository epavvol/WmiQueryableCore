using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_RcmSqlControlProperty
    /// </summary>
    [WmiClass(Name = "SMS_RcmSqlControlProperty")]
    public class SmsRcmSqlControlProperty
    {
        /// <summary>
        /// WMI Property PropertyName
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public uint Value { get; set; }
        /// <summary>
        /// WMI Property Value1
        /// </summary>
        public string Value1 { get; set; }
        /// <summary>
        /// WMI Property Value2
        /// </summary>
        public string Value2 { get; set; }
    }
}
