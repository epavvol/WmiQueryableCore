using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_HA_SiteServerTopLevelMonitoring
    /// </summary>
    [WmiClass(Name = "SMS_HA_SiteServerTopLevelMonitoring")]
    public class SmsHaSiteServerTopLevelMonitoring
    {
        /// <summary>
        /// WMI Property MessageTime
        /// </summary>
        public DateTime MessageTime { get; set; }
        /// <summary>
        /// WMI Property OrderId
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteServerName
        /// </summary>
        public string SiteServerName { get; set; }
        /// <summary>
        /// WMI Property StageCompleted
        /// </summary>
        public int StageCompleted { get; set; }
        /// <summary>
        /// WMI Property StageId
        /// </summary>
        public int StageId { get; set; }
        /// <summary>
        /// WMI Property StageName
        /// </summary>
        public string StageName { get; set; }
    }
}
