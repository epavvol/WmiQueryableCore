using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDataSourcesPolicy
    /// </summary>
    [WmiClass(Name = "SMS_ClientDataSourcesPolicy")]
    public class SmsClientDataSourcesPolicy
    {
        /// <summary>
        /// WMI Property BranchCacheBytes
        /// </summary>
        public ulong BranchCacheBytes { get; set; }
        /// <summary>
        /// WMI Property ManagementPointBytes
        /// </summary>
        public ulong ManagementPointBytes { get; set; }
    }
}
