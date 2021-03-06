using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CH_ClientHealth
    /// </summary>
    [WmiClass(Name = "SMS_CH_ClientHealth")]
    public class SmsChClientHealth
    {
        /// <summary>
        /// WMI Property Client_Version0
        /// </summary>
        [WmiProperty(Name = "Client_Version0")]
        public string ClientVersion0 { get; set; }
        /// <summary>
        /// WMI Property ClientActiveStatus
        /// </summary>
        public uint ClientActiveStatus { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property IsActiveDDR
        /// </summary>
        public uint IsActiveDdr { get; set; }
        /// <summary>
        /// WMI Property IsActiveHW
        /// </summary>
        public uint IsActiveHw { get; set; }
        /// <summary>
        /// WMI Property IsActivePolicyRequest
        /// </summary>
        public uint IsActivePolicyRequest { get; set; }
        /// <summary>
        /// WMI Property IsActiveStatusMessages
        /// </summary>
        public uint IsActiveStatusMessages { get; set; }
        /// <summary>
        /// WMI Property IsActiveSW
        /// </summary>
        public uint IsActiveSw { get; set; }
        /// <summary>
        /// WMI Property IsClient
        /// </summary>
        public uint IsClient { get; set; }
        /// <summary>
        /// WMI Property LastActiveTime
        /// </summary>
        public DateTime LastActiveTime { get; set; }
        /// <summary>
        /// WMI Property LastDDR
        /// </summary>
        public DateTime LastDdr { get; set; }
        /// <summary>
        /// WMI Property LastEvaluationHealthy
        /// </summary>
        public uint LastEvaluationHealthy { get; set; }
        /// <summary>
        /// WMI Property LastHealthEvaluation
        /// </summary>
        public DateTime LastHealthEvaluation { get; set; }
        /// <summary>
        /// WMI Property LastHealthEvaluationResult
        /// </summary>
        public uint LastHealthEvaluationResult { get; set; }
        /// <summary>
        /// WMI Property LastHW
        /// </summary>
        public DateTime LastHw { get; set; }
        /// <summary>
        /// WMI Property LastOfflineTime
        /// </summary>
        public DateTime LastOfflineTime { get; set; }
        /// <summary>
        /// WMI Property LastOnlineTime
        /// </summary>
        public DateTime LastOnlineTime { get; set; }
        /// <summary>
        /// WMI Property LastPolicyRequest
        /// </summary>
        public DateTime LastPolicyRequest { get; set; }
        /// <summary>
        /// WMI Property LastStatusMessage
        /// </summary>
        public DateTime LastStatusMessage { get; set; }
        /// <summary>
        /// WMI Property LastSW
        /// </summary>
        public DateTime LastSw { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property OnlineStatus
        /// </summary>
        public uint OnlineStatus { get; set; }
        /// <summary>
        /// WMI Property Operating_System_Name_and0
        /// </summary>
        [WmiProperty(Name = "Operating_System_Name_and0")]
        public string OperatingSystemNameAnd0 { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public string SiteId { get; set; }
    }
}
