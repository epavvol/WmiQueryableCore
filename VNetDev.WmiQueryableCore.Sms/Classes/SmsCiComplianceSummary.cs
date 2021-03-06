using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CI_ComplianceSummary
    /// </summary>
    [WmiClass(Name = "SMS_CI_ComplianceSummary")]
    public class SmsCiComplianceSummary
    {
        /// <summary>
        /// WMI Property ActivatedCount
        /// </summary>
        public uint ActivatedCount { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "CI_UniqueID")]
        public string CiUniqueId { get; set; }
        /// <summary>
        /// WMI Property CountCompliant
        /// </summary>
        public uint CountCompliant { get; set; }
        /// <summary>
        /// WMI Property CountNoncompliant
        /// </summary>
        public uint CountNoncompliant { get; set; }
        /// <summary>
        /// WMI Property CountTargeted
        /// </summary>
        public uint CountTargeted { get; set; }
        /// <summary>
        /// WMI Property FailureCount
        /// </summary>
        public uint FailureCount { get; set; }
        /// <summary>
        /// WMI Property LastSummaryTime
        /// </summary>
        public DateTime LastSummaryTime { get; set; }
        /// <summary>
        /// WMI Property ModelName
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// WMI Property Severity
        /// </summary>
        public uint Severity { get; set; }
    }
}
