using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SystemResourceList
    /// </summary>
    [WmiClass(Name = "SMS_SystemResourceList")]
    public class SmsSystemResourceList
    {
        /// <summary>
        /// WMI Property InternetEnabled
        /// </summary>
        public bool InternetEnabled { get; set; }
        /// <summary>
        /// WMI Property InternetShared
        /// </summary>
        public bool InternetShared { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// WMI Property RoleName
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// WMI Property ServerRemoteName
        /// </summary>
        public string ServerRemoteName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SslState
        /// </summary>
        public uint SslState { get; set; }
    }
}
