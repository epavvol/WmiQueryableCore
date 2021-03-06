using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CloudAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_CloudAgentConfig")]
    public class SmsCloudAgentConfig
    {
        /// <summary>
        /// WMI Property AADAuthFlags
        /// </summary>
        public uint AadAuthFlags { get; set; }
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property AllowCloudDP
        /// </summary>
        public bool AllowCloudDp { get; set; }
        /// <summary>
        /// WMI Property AllowCMG
        /// </summary>
        public bool AllowCmg { get; set; }
        /// <summary>
        /// WMI Property AutoAADJoin
        /// </summary>
        public bool AutoAadJoin { get; set; }
        /// <summary>
        /// WMI Property AutoMDMEnrollment
        /// </summary>
        public bool AutoMdmEnrollment { get; set; }
        /// <summary>
        /// WMI Property CoManagementFlags
        /// </summary>
        public uint CoManagementFlags { get; set; }
    }
}
