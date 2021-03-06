using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_StateSystemConfig
    /// </summary>
    [WmiClass(Name = "SMS_StateSystemConfig")]
    public class SmsStateSystemConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property BulkSendInterval
        /// </summary>
        public uint BulkSendInterval { get; set; }
        /// <summary>
        /// WMI Property BulkSendIntervalHigh
        /// </summary>
        public uint BulkSendIntervalHigh { get; set; }
        /// <summary>
        /// WMI Property BulkSendIntervalLow
        /// </summary>
        public uint BulkSendIntervalLow { get; set; }
        /// <summary>
        /// WMI Property CacheCleanoutInterval
        /// </summary>
        public string CacheCleanoutInterval { get; set; }
        /// <summary>
        /// WMI Property CacheMaxAge
        /// </summary>
        public uint CacheMaxAge { get; set; }
    }
}
