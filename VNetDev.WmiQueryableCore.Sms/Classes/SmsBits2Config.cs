using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BITS2Config
    /// </summary>
    [WmiClass(Name = "SMS_BITS2Config")]
    public class SmsBits2Config
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property ApplyToAllClients
        /// </summary>
        public bool ApplyToAllClients { get; set; }
        /// <summary>
        /// WMI Property EnableBitsMaxBandwidth
        /// </summary>
        public bool EnableBitsMaxBandwidth { get; set; }
        /// <summary>
        /// WMI Property EnableDownloadOffSchedule
        /// </summary>
        public bool EnableDownloadOffSchedule { get; set; }
        /// <summary>
        /// WMI Property MaxBandwidthValidFrom
        /// </summary>
        public uint MaxBandwidthValidFrom { get; set; }
        /// <summary>
        /// WMI Property MaxBandwidthValidTo
        /// </summary>
        public uint MaxBandwidthValidTo { get; set; }
        /// <summary>
        /// WMI Property MaxTransferRateOffSchedule
        /// </summary>
        public uint MaxTransferRateOffSchedule { get; set; }
        /// <summary>
        /// WMI Property MaxTransferRateOnSchedule
        /// </summary>
        public uint MaxTransferRateOnSchedule { get; set; }
    }
}
