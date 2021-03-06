using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CloudProxyRoleEndpoint
    /// </summary>
    [WmiClass(Name = "SMS_CloudProxyRoleEndpoint")]
    public class SmsCloudProxyRoleEndpoint
    {
        /// <summary>
        /// WMI Property EndpointName
        /// </summary>
        public string EndpointName { get; set; }
        /// <summary>
        /// WMI Property InternalEndpointName
        /// </summary>
        public string InternalEndpointName { get; set; }
        /// <summary>
        /// WMI Property MaxConcurrentRequestsLast30Days
        /// </summary>
        public uint MaxConcurrentRequestsLast30Days { get; set; }
        /// <summary>
        /// WMI Property ProxyServiceName
        /// </summary>
        public string ProxyServiceName { get; set; }
        /// <summary>
        /// WMI Property RoleID
        /// </summary>
        public ulong RoleId { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// WMI Property RoleServerName
        /// </summary>
        public string RoleServerName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property TotalRequestMBLast30Days
        /// </summary>
        public ulong TotalRequestMbLast30Days { get; set; }
        /// <summary>
        /// WMI Property TotalRequestsLast30Days
        /// </summary>
        public uint TotalRequestsLast30Days { get; set; }
        /// <summary>
        /// WMI Property TotalResponseMBLast30Days
        /// </summary>
        public ulong TotalResponseMbLast30Days { get; set; }
    }
}
