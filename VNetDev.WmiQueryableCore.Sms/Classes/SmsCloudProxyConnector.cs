using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CloudProxyConnector
    /// </summary>
    [WmiClass(Name = "SMS_CloudProxyConnector")]
    public class SmsCloudProxyConnector
    {
        /// <summary>
        /// WMI Property ConnectionStatus
        /// </summary>
        public uint ConnectionStatus { get; set; }
        /// <summary>
        /// WMI Property MaxConcurrentRequestsLast30Days
        /// </summary>
        public uint MaxConcurrentRequestsLast30Days { get; set; }
        /// <summary>
        /// WMI Property ProxyServiceName
        /// </summary>
        public string ProxyServiceName { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
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
