using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_SysResUse
    /// </summary>
    [WmiClass(Name = "SMS_SCI_SysResUse")]
    public class SmsSciSysResUse
    {
        /// <summary>
        /// WMI static method <c>HasMonitoringStatus</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="serverName">WMI Property <c>ServerName</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint HasMonitoringStatusDelegate(WmiContext wmiContext, string serverName = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>HasMonitoringStatus</c>.
        /// </summary>
        public static HasMonitoringStatusDelegate HasMonitoringStatus;
        
        /// <summary>
        /// WMI static method <c>RetryInstallation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="roleName">WMI Property <c>RoleName</c> of type <c>string</c>.</param>
        /// <param name="serverName">WMI Property <c>ServerName</c> of type <c>string</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RetryInstallationDelegate(WmiContext wmiContext, string roleName = default, string serverName = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>RetryInstallation</c>.
        /// </summary>
        public static RetryInstallationDelegate RetryInstallation;
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property NALType
        /// </summary>
        public string NalType { get; set; }
        /// <summary>
        /// WMI Property NetworkOSPath
        /// </summary>
        public string NetworkOsPath { get; set; }
        /// <summary>
        /// WMI Property PropLists
        /// </summary>
        public  ICollection<SmsEmbeddedPropertyList> PropLists { get; set; }
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public  ICollection<SmsEmbeddedProperty> Props { get; set; }
        /// <summary>
        /// WMI Property RoleCount
        /// </summary>
        public uint RoleCount { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// WMI Property ServerState
        /// </summary>
        public uint ServerState { get; set; }
        /// <summary>
        /// WMI Property ServiceWindows
        /// </summary>
        public ICollection<SmsServiceWindow> ServiceWindows { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteSystemStatus
        /// </summary>
        public uint SiteSystemStatus { get; set; }
        /// <summary>
        /// WMI Property SslState
        /// </summary>
        public uint SslState { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
