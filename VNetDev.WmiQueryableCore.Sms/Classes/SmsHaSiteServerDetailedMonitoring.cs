using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_HA_SiteServerDetailedMonitoring
    /// </summary>
    [WmiClass(Name = "SMS_HA_SiteServerDetailedMonitoring")]
    public class SmsHaSiteServerDetailedMonitoring
    {
        /// <summary>
        /// WMI Property Applicable
        /// </summary>
        public int Applicable { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property IsComplete
        /// </summary>
        public int IsComplete { get; set; }
        /// <summary>
        /// WMI Property MessageTime
        /// </summary>
        public DateTime MessageTime { get; set; }
        /// <summary>
        /// WMI Property OrderId
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// WMI Property Parameter
        /// </summary>
        public string Parameter { get; set; }
        /// <summary>
        /// WMI Property Progress
        /// </summary>
        public int Progress { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteServerInstallID
        /// </summary>
        public int SiteServerInstallId { get; set; }
        /// <summary>
        /// WMI Property SiteServerName
        /// </summary>
        public string SiteServerName { get; set; }
        /// <summary>
        /// WMI Property StageId
        /// </summary>
        public int StageId { get; set; }
        /// <summary>
        /// WMI Property SubStageid
        /// </summary>
        public int SubStageid { get; set; }
        /// <summary>
        /// WMI Property SubStageName
        /// </summary>
        public string SubStageName { get; set; }
    }
}
