using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConsoleAdminsData
    /// </summary>
    [WmiClass(Name = "SMS_ConsoleAdminsData")]
    public class SmsConsoleAdminsData
    {
        /// <summary>
        /// WMI Property ConnectedSiteCode
        /// </summary>
        public string ConnectedSiteCode { get; set; }
        /// <summary>
        /// WMI Property ConsoleConnectTime
        /// </summary>
        public DateTime ConsoleConnectTime { get; set; }
        /// <summary>
        /// WMI Property ConsoleVersion
        /// </summary>
        public string ConsoleVersion { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property Source
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property UserPrincipalName
        /// </summary>
        public string UserPrincipalName { get; set; }
    }
}
