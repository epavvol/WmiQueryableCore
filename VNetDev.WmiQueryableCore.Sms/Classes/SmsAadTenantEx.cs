using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Tenant_Ex
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Tenant_Ex")]
    public class SmsAadTenantEx
    {
        /// <summary>
        /// WMI Property Environment
        /// </summary>
        public uint Environment { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property TenantID
        /// </summary>
        public string TenantId { get; set; }
    }
}
