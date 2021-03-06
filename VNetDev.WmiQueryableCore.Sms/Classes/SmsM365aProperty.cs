using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_M365AProperty
    /// </summary>
    [WmiClass(Name = "SMS_M365AProperty")]
    public class SmsM365aProperty
    {
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property PropertyName
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// WMI Property TenantID
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// WMI Property TenantName
        /// </summary>
        public string TenantName { get; set; }
        /// <summary>
        /// WMI Property Value
        /// </summary>
        public string Value { get; set; }
    }
}
