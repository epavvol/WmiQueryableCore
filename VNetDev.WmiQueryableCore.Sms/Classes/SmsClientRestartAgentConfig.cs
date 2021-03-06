using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientRestartAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_ClientRestartAgentConfig")]
    public class SmsClientRestartAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property CountdownSnoozeInterval
        /// </summary>
        public uint CountdownSnoozeInterval { get; set; }
        /// <summary>
        /// WMI Property RebootLogoffNotificationCountdownDuration
        /// </summary>
        public uint RebootLogoffNotificationCountdownDuration { get; set; }
        /// <summary>
        /// WMI Property RebootLogoffNotificationFinalWindow
        /// </summary>
        public uint RebootLogoffNotificationFinalWindow { get; set; }
        /// <summary>
        /// WMI Property RebootNotificationsDialog
        /// </summary>
        public bool RebootNotificationsDialog { get; set; }
    }
}
