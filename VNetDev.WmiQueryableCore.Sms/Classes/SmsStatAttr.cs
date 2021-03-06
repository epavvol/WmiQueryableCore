using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StatAttr
    /// </summary>
    [WmiClass(Name = "SMS_StatAttr")]
    public class SmsStatAttr
    {
        /// <summary>
        /// WMI Property AttributeID
        /// </summary>
        public uint AttributeId { get; set; }
        /// <summary>
        /// WMI Property AttributeTime
        /// </summary>
        public DateTime AttributeTime { get; set; }
        /// <summary>
        /// WMI Property AttributeValue
        /// </summary>
        public string AttributeValue { get; set; }
        /// <summary>
        /// WMI Property RecordID
        /// </summary>
        public long RecordId { get; set; }
    }
}
