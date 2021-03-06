using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_CH_ClientSummary
    /// </summary>
    [WmiClass(Name = "SMS_G_System_CH_ClientSummary")]
    public class SmsGSystemChClientSummary
    {
        /// <summary>
        /// WMI Property ADLastLogonTime
        /// </summary>
        public DateTime AdLastLogonTime { get; set; }
        /// <summary>
        /// WMI Property ClientActiveStatus
        /// </summary>
        public int ClientActiveStatus { get; set; }
        /// <summary>
        /// WMI Property ClientCheckPass
        /// </summary>
        public uint ClientCheckPass { get; set; }
        /// <summary>
        /// WMI Property ClientRemediationSuccess
        /// </summary>
        public uint ClientRemediationSuccess { get; set; }
        /// <summary>
        /// WMI Property LastActiveTime
        /// </summary>
        public DateTime LastActiveTime { get; set; }
        /// <summary>
        /// WMI Property LastClientCheckTime
        /// </summary>
        public DateTime LastClientCheckTime { get; set; }
        /// <summary>
        /// WMI Property LastDDR
        /// </summary>
        public DateTime LastDdr { get; set; }
        /// <summary>
        /// WMI Property LastHardwareScan
        /// </summary>
        public DateTime LastHardwareScan { get; set; }
        /// <summary>
        /// WMI Property LastMPServerName
        /// </summary>
        public string LastMpServerName { get; set; }
        /// <summary>
        /// WMI Property LastPolicyRequest
        /// </summary>
        public DateTime LastPolicyRequest { get; set; }
        /// <summary>
        /// WMI Property LastSoftwareScan
        /// </summary>
        public DateTime LastSoftwareScan { get; set; }
        /// <summary>
        /// WMI Property LastStatusMessage
        /// </summary>
        public DateTime LastStatusMessage { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
