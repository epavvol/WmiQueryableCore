using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DPGroupDistributionStatus
    /// </summary>
    [WmiClass(Name = "SMS_DPGroupDistributionStatus")]
    public class SmsDpGroupDistributionStatus
    {
        /// <summary>
        /// WMI Property Assets
        /// </summary>
        public uint Assets { get; set; }
        /// <summary>
        /// WMI Property ContentCount
        /// </summary>
        public uint ContentCount { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property MessageCategory
        /// </summary>
        public uint MessageCategory { get; set; }
        /// <summary>
        /// WMI Property MessageType
        /// </summary>
        public uint MessageType { get; set; }
        /// <summary>
        /// WMI Property StatusTime
        /// </summary>
        public DateTime StatusTime { get; set; }
    }
}
