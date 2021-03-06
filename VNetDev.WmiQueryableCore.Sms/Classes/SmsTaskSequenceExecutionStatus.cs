using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequenceExecutionStatus
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequenceExecutionStatus")]
    public class SmsTaskSequenceExecutionStatus
    {
        /// <summary>
        /// WMI Property ActionName
        /// </summary>
        public string ActionName { get; set; }
        /// <summary>
        /// WMI Property ActionOutput
        /// </summary>
        public string ActionOutput { get; set; }
        /// <summary>
        /// WMI Property AdvertisementID
        /// </summary>
        public string AdvertisementId { get; set; }
        /// <summary>
        /// WMI Property ExecutionTime
        /// </summary>
        public DateTime ExecutionTime { get; set; }
        /// <summary>
        /// WMI Property ExitCode
        /// </summary>
        public uint ExitCode { get; set; }
        /// <summary>
        /// WMI Property GroupName
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// WMI Property LastStatusMsgID
        /// </summary>
        public uint LastStatusMsgId { get; set; }
        /// <summary>
        /// WMI Property LastStatusMsgName
        /// </summary>
        public string LastStatusMsgName { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Step
        /// </summary>
        public uint Step { get; set; }
    }
}
