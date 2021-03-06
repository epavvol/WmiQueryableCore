using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Tenant_Ex_Property
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Tenant_Ex_Property")]
    public class SmsAadTenantExProperty
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
