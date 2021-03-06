using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_Threats
    /// </summary>
    [WmiClass(Name = "SMS_G_System_Threats")]
    public class SmsGSystemThreats
    {
        /// <summary>
        /// WMI Property ActionSuccess
        /// </summary>
        public bool ActionSuccess { get; set; }
        /// <summary>
        /// WMI Property ActionTime
        /// </summary>
        public DateTime ActionTime { get; set; }
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// WMI Property CategoryID
        /// </summary>
        public byte CategoryId { get; set; }
        /// <summary>
        /// WMI Property CleaningAction
        /// </summary>
        public byte CleaningAction { get; set; }
        /// <summary>
        /// WMI Property DetectionID
        /// </summary>
        public string DetectionId { get; set; }
        /// <summary>
        /// WMI Property DetectionSource
        /// </summary>
        public byte DetectionSource { get; set; }
        /// <summary>
        /// WMI Property DetectionTime
        /// </summary>
        public DateTime DetectionTime { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// WMI Property ExecutionStatus
        /// </summary>
        public byte ExecutionStatus { get; set; }
        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// WMI Property PendingActions
        /// </summary>
        public uint PendingActions { get; set; }
        /// <summary>
        /// WMI Property Process
        /// </summary>
        public string Process { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public string Severity { get; set; }
        /// <summary>
        /// WMI Property SeverityID
        /// </summary>
        public byte SeverityId { get; set; }
        /// <summary>
        /// WMI Property ThreatID
        /// </summary>
        public ulong ThreatId { get; set; }
        /// <summary>
        /// WMI Property ThreatName
        /// </summary>
        public string ThreatName { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
