using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UpdateDeploymentClientSummary
    /// </summary>
    [WmiClass(Name = "SMS_UpdateDeploymentClientSummary")]
    public class SmsUpdateDeploymentClientSummary
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public string AssignmentId { get; set; }
        /// <summary>
        /// WMI Property NumCompliant
        /// </summary>
        public uint NumCompliant { get; set; }
        /// <summary>
        /// WMI Property NumFailed
        /// </summary>
        public uint NumFailed { get; set; }
        /// <summary>
        /// WMI Property NumHealthy
        /// </summary>
        public uint NumHealthy { get; set; }
        /// <summary>
        /// WMI Property NumHealthyCompliant
        /// </summary>
        public uint NumHealthyCompliant { get; set; }
        /// <summary>
        /// WMI Property NumHealthyFailed
        /// </summary>
        public uint NumHealthyFailed { get; set; }
        /// <summary>
        /// WMI Property NumNonCompliant
        /// </summary>
        public uint NumNonCompliant { get; set; }
        /// <summary>
        /// WMI Property NumPending
        /// </summary>
        public uint NumPending { get; set; }
        /// <summary>
        /// WMI Property NumTotal
        /// </summary>
        public uint NumTotal { get; set; }
        /// <summary>
        /// WMI Property NumUnknown
        /// </summary>
        public uint NumUnknown { get; set; }
    }
}
