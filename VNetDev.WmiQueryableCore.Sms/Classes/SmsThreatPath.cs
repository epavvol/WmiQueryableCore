using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ThreatPath
    /// </summary>
    [WmiClass(Name = "SMS_ThreatPath")]
    public class SmsThreatPath
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property DuplicateCount
        /// </summary>
        public uint DuplicateCount { get; set; }
        /// <summary>
        /// WMI Property Path
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public ulong ResourceId { get; set; }
        /// <summary>
        /// WMI Property ThreatID
        /// </summary>
        public ulong ThreatId { get; set; }
        /// <summary>
        /// WMI Property ThreatName
        /// </summary>
        public string ThreatName { get; set; }
        /// <summary>
        /// WMI Property TotalCount
        /// </summary>
        public uint TotalCount { get; set; }
    }
}
