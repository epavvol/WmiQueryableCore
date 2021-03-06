using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TargetingAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_TargetingAgentConfig")]
    public class SmsTargetingAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property AllowUserAffinity
        /// </summary>
        public uint AllowUserAffinity { get; set; }
        /// <summary>
        /// WMI Property AllowUserAffinityAfterMinutes
        /// </summary>
        public uint AllowUserAffinityAfterMinutes { get; set; }
        /// <summary>
        /// WMI Property AutoApproveAffinity
        /// </summary>
        public uint AutoApproveAffinity { get; set; }
        /// <summary>
        /// WMI Property ConsoleMinutes
        /// </summary>
        public uint ConsoleMinutes { get; set; }
        /// <summary>
        /// WMI Property IntervalDays
        /// </summary>
        public uint IntervalDays { get; set; }
    }
}
