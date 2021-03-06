using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDataSourcesContent
    /// </summary>
    [WmiClass(Name = "SMS_ClientDataSourcesContent")]
    public class SmsClientDataSourcesContent
    {
        /// <summary>
        /// WMI Property BranchCacheBytes
        /// </summary>
        public ulong BranchCacheBytes { get; set; }
        /// <summary>
        /// WMI Property CloudDistributionPointBytes
        /// </summary>
        public ulong CloudDistributionPointBytes { get; set; }
        /// <summary>
        /// WMI Property DistributionPointBytes
        /// </summary>
        public ulong DistributionPointBytes { get; set; }
        /// <summary>
        /// WMI Property DpSourceServerCount
        /// </summary>
        public uint DpSourceServerCount { get; set; }
        /// <summary>
        /// WMI Property PeerCacheBytes
        /// </summary>
        public ulong PeerCacheBytes { get; set; }
        /// <summary>
        /// WMI Property SpSourceClientCount
        /// </summary>
        public uint SpSourceClientCount { get; set; }
    }
}
