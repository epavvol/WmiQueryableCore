using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OMSConfigurationData
    /// </summary>
    [WmiClass(Name = "SMS_OMSConfigurationData")]
    public class SmsOmsConfigurationData
    {
        /// <summary>
        /// WMI Property TenantName
        /// </summary>
        public string TenantName { get; set; }
        /// <summary>
        /// WMI Property WorkspaceName
        /// </summary>
        public string WorkspaceName { get; set; }
    }
}
