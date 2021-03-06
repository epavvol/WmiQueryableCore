using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ReadinessDashboardConfigurationData
    /// </summary>
    [WmiClass(Name = "SMS_ReadinessDashboardConfigurationData")]
    public class SmsReadinessDashboardConfigurationData
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
