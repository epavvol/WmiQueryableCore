using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_LocalizedNameLookup
    /// </summary>
    [WmiClass(Name = "SMS_LocalizedNameLookup")]
    public class SmsLocalizedNameLookup
    {
        /// <summary>
        /// WMI Property ColumnName
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// WMI Property ResourceDLL
        /// </summary>
        public string ResourceDll { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
