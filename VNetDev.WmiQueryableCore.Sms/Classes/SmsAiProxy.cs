using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AIProxy
    /// </summary>
    [WmiClass(Name = "SMS_AIProxy")]
    public class SmsAiProxy
    {
        /// <summary>
        /// WMI static method <c>RequestCatalogUpdate</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="proxyName">WMI Property <c>ProxyName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestCatalogUpdateDelegate(WmiContext wmiContext, string proxyName = default);
        /// <summary>
        /// WMI static method <c>RequestCatalogUpdate</c>.
        /// </summary>
        public static RequestCatalogUpdateDelegate RequestCatalogUpdate;
        /// <summary>
        /// WMI Property CatalogWatermark
        /// </summary>
        public string CatalogWatermark { get; set; }
        /// <summary>
        /// WMI Property CategoryChangeCount
        /// </summary>
        public uint CategoryChangeCount { get; set; }
        /// <summary>
        /// WMI Property CPUChangeCount
        /// </summary>
        public uint CpuChangeCount { get; set; }
        /// <summary>
        /// WMI Property HWReqChangeCount
        /// </summary>
        public uint HwReqChangeCount { get; set; }
        /// <summary>
        /// WMI Property LastCatalogUpdateCompletion
        /// </summary>
        public DateTime LastCatalogUpdateCompletion { get; set; }
        /// <summary>
        /// WMI Property LastCatalogUpdateRequest
        /// </summary>
        public DateTime LastCatalogUpdateRequest { get; set; }
        /// <summary>
        /// WMI Property LastSCOReturnCode
        /// </summary>
        public uint LastScoReturnCode { get; set; }
        /// <summary>
        /// WMI Property PeriodicCatalogUpdateEnabled
        /// </summary>
        public bool PeriodicCatalogUpdateEnabled { get; set; }
        /// <summary>
        /// WMI Property PeriodicCatalogUpdateSchedule
        /// </summary>
        public string PeriodicCatalogUpdateSchedule { get; set; }
        /// <summary>
        /// WMI Property Port
        /// </summary>
        public uint Port { get; set; }
        /// <summary>
        /// WMI Property ProxyCertPath
        /// </summary>
        public string ProxyCertPath { get; set; }
        /// <summary>
        /// WMI Property ProxyEnabled
        /// </summary>
        public bool ProxyEnabled { get; set; }
        /// <summary>
        /// WMI Property ProxyName
        /// </summary>
        public string ProxyName { get; set; }
        /// <summary>
        /// WMI Property ProxyPollingInterval
        /// </summary>
        public uint ProxyPollingInterval { get; set; }
        /// <summary>
        /// WMI Property ProxyState
        /// </summary>
        public uint ProxyState { get; set; }
        /// <summary>
        /// WMI Property RelevancyOptOut
        /// </summary>
        public bool RelevancyOptOut { get; set; }
        /// <summary>
        /// WMI Property SCOURL
        /// </summary>
        public string Scourl { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SoftwareTitlesChangeCount
        /// </summary>
        public uint SoftwareTitlesChangeCount { get; set; }
    }
}
