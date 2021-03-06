using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionJob
    /// </summary>
    [WmiClass(Name = "SMS_DistributionJob")]
    public class SmsDistributionJob
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public uint Action { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property DPID
        /// </summary>
        public uint Dpid { get; set; }
        /// <summary>
        /// WMI Property DynamicOrder
        /// </summary>
        public uint DynamicOrder { get; set; }
        /// <summary>
        /// WMI Property JobID
        /// </summary>
        public ulong JobId { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property PackageVersion
        /// </summary>
        public uint PackageVersion { get; set; }
        /// <summary>
        /// WMI Property PkgID
        /// </summary>
        public string PkgId { get; set; }
        /// <summary>
        /// WMI Property RemainingSize
        /// </summary>
        public ulong RemainingSize { get; set; }
        /// <summary>
        /// WMI Property ReStartTime
        /// </summary>
        public DateTime ReStartTime { get; set; }
        /// <summary>
        /// WMI Property RetryCount
        /// </summary>
        public uint RetryCount { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property TotalSize
        /// </summary>
        public ulong TotalSize { get; set; }
    }
}
