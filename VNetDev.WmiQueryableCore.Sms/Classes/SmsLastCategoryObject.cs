using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_LastCategoryObject
    /// </summary>
    [WmiClass(Name = "SMS_LastCategoryObject")]
    public class SmsLastCategoryObject
    {
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// WMI Property ObjectKey
        /// </summary>
        public string ObjectKey { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
    }
}
