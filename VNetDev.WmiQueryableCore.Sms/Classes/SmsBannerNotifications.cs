using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BannerNotifications
    /// </summary>
    [WmiClass(Name = "SMS_BannerNotifications")]
    public class SmsBannerNotifications
    {
        /// <summary>
        /// WMI Property DateLastModified
        /// </summary>
        public DateTime DateLastModified { get; set; }
        /// <summary>
        /// WMI Property DismissOption
        /// </summary>
        public uint DismissOption { get; set; }
        /// <summary>
        /// WMI Property DismissState
        /// </summary>
        public uint DismissState { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property MaxCMVersion
        /// </summary>
        public string MaxCmVersion { get; set; }
        /// <summary>
        /// WMI Property MinCMVersion
        /// </summary>
        public string MinCmVersion { get; set; }
        /// <summary>
        /// WMI Property NotificationData
        /// </summary>
        public string NotificationData { get; set; }
        /// <summary>
        /// WMI Property RoleId
        /// </summary>
        public uint RoleId { get; set; }
        /// <summary>
        /// WMI Property ScopeId
        /// </summary>
        public uint ScopeId { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public uint Severity { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property UniqueId
        /// </summary>
        public string UniqueId { get; set; }
    }
}
