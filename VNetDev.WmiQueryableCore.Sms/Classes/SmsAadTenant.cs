using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Tenant
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Tenant")]
    public class SmsAadTenant
    {
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
    }
}
