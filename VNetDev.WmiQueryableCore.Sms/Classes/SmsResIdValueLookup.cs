using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ResIDValueLookup
    /// </summary>
    [WmiClass(Name = "SMS_ResIDValueLookup")]
    public class SmsResIdValueLookup
    {
        /// <summary>
        /// WMI Property IntLookupValue
        /// </summary>
        public uint IntLookupValue { get; set; }
        /// <summary>
        /// WMI Property LookupName
        /// </summary>
        public string LookupName { get; set; }
        /// <summary>
        /// WMI Property ResDLL
        /// </summary>
        public string ResDll { get; set; }
        /// <summary>
        /// WMI Property ResID
        /// </summary>
        public uint ResId { get; set; }
        /// <summary>
        /// WMI Property StringLookupValue
        /// </summary>
        public string StringLookupValue { get; set; }
    }
}
