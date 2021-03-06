using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PolicyAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_PolicyAgentConfig")]
    public class SmsPolicyAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property PolicyDownloadMethod
        /// </summary>
        public string PolicyDownloadMethod { get; set; }
        /// <summary>
        /// WMI Property PolicyEnableUserAuthForAllUserPolicies
        /// </summary>
        public bool PolicyEnableUserAuthForAllUserPolicies { get; set; }
        /// <summary>
        /// WMI Property PolicyEnableUserGroupSupport
        /// </summary>
        public bool PolicyEnableUserGroupSupport { get; set; }
        /// <summary>
        /// WMI Property PolicyEnableUserPolicyOnInternet
        /// </summary>
        public bool PolicyEnableUserPolicyOnInternet { get; set; }
        /// <summary>
        /// WMI Property PolicyEnableUserPolicyOnTS
        /// </summary>
        public bool PolicyEnableUserPolicyOnTs { get; set; }
        /// <summary>
        /// WMI Property PolicyEnableUserPolicyPolling
        /// </summary>
        public bool PolicyEnableUserPolicyPolling { get; set; }
        /// <summary>
        /// WMI Property PolicyRequestAssignmentTimeout
        /// </summary>
        public uint PolicyRequestAssignmentTimeout { get; set; }
        /// <summary>
        /// WMI Property PolicyTimeDelayBeforeUserPolicyRefreshAtLogonOrUnlock
        /// </summary>
        public uint PolicyTimeDelayBeforeUserPolicyRefreshAtLogonOrUnlock { get; set; }
        /// <summary>
        /// WMI Property PolicyTimeUntilAck
        /// </summary>
        public uint PolicyTimeUntilAck { get; set; }
        /// <summary>
        /// WMI Property PolicyTimeUntilExpire
        /// </summary>
        public uint PolicyTimeUntilExpire { get; set; }
        /// <summary>
        /// WMI Property PolicyTimeUntilUpdateActualConfig
        /// </summary>
        public uint PolicyTimeUntilUpdateActualConfig { get; set; }
    }
}
