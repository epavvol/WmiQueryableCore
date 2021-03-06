using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_SYSTEMBOOTSUMMARY
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_SYSTEMBOOTSUMMARY")]
    public class SmsGhSystemSystembootsummary
    {
        /// <summary>
        /// WMI Property AverageBootFrequency
        /// </summary>
        public uint AverageBootFrequency { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LatestBiosDuration
        /// </summary>
        public uint LatestBiosDuration { get; set; }
        /// <summary>
        /// WMI Property LatestBootDuration
        /// </summary>
        public uint LatestBootDuration { get; set; }
        /// <summary>
        /// WMI Property LatestCoreBootDuration
        /// </summary>
        public uint LatestCoreBootDuration { get; set; }
        /// <summary>
        /// WMI Property LatestEventLogStart
        /// </summary>
        public uint LatestEventLogStart { get; set; }
        /// <summary>
        /// WMI Property LatestGPDuration
        /// </summary>
        public uint LatestGpDuration { get; set; }
        /// <summary>
        /// WMI Property LatestUpdateDuration
        /// </summary>
        public uint LatestUpdateDuration { get; set; }
        /// <summary>
        /// WMI Property MaxBiosDuration
        /// </summary>
        public uint MaxBiosDuration { get; set; }
        /// <summary>
        /// WMI Property MaxBootDuration
        /// </summary>
        public uint MaxBootDuration { get; set; }
        /// <summary>
        /// WMI Property MaxCoreBootDuration
        /// </summary>
        public uint MaxCoreBootDuration { get; set; }
        /// <summary>
        /// WMI Property MaxEventLogStart
        /// </summary>
        public uint MaxEventLogStart { get; set; }
        /// <summary>
        /// WMI Property MaxGPDuration
        /// </summary>
        public uint MaxGpDuration { get; set; }
        /// <summary>
        /// WMI Property MaxUpdateDuration
        /// </summary>
        public uint MaxUpdateDuration { get; set; }
        /// <summary>
        /// WMI Property MedianBiosDuration
        /// </summary>
        public uint MedianBiosDuration { get; set; }
        /// <summary>
        /// WMI Property MedianBootDuration
        /// </summary>
        public uint MedianBootDuration { get; set; }
        /// <summary>
        /// WMI Property MedianCoreBootDuration
        /// </summary>
        public uint MedianCoreBootDuration { get; set; }
        /// <summary>
        /// WMI Property MedianEventLogStart
        /// </summary>
        public uint MedianEventLogStart { get; set; }
        /// <summary>
        /// WMI Property MedianGPDuration
        /// </summary>
        public uint MedianGpDuration { get; set; }
        /// <summary>
        /// WMI Property MedianUpdateDuration
        /// </summary>
        public uint MedianUpdateDuration { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
