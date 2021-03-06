using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SUMDeploymentStatistics
    /// </summary>
    [WmiClass(Name = "SMS_SUMDeploymentStatistics")]
    public class SmsSumDeploymentStatistics
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property NumError
        /// </summary>
        public uint NumError { get; set; }
        /// <summary>
        /// WMI Property NumInProgress
        /// </summary>
        public uint NumInProgress { get; set; }
        /// <summary>
        /// WMI Property NumReqsNotMet
        /// </summary>
        public uint NumReqsNotMet { get; set; }
        /// <summary>
        /// WMI Property NumSuccess
        /// </summary>
        public uint NumSuccess { get; set; }
        /// <summary>
        /// WMI Property NumUnknown
        /// </summary>
        public uint NumUnknown { get; set; }
        /// <summary>
        /// WMI Property SummarizationTime
        /// </summary>
        public DateTime SummarizationTime { get; set; }
    }
}
