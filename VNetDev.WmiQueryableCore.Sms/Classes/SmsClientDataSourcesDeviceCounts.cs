using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientDataSourcesDeviceCounts
    /// </summary>
    [WmiClass(Name = "SMS_ClientDataSourcesDeviceCounts")]
    public class SmsClientDataSourcesDeviceCounts
    {
        /// <summary>
        /// WMI Property ClientCount
        /// </summary>
        public uint ClientCount { get; set; }
        /// <summary>
        /// WMI Property DPCount
        /// </summary>
        public uint DpCount { get; set; }
        /// <summary>
        /// WMI Property PeerClientCount
        /// </summary>
        public uint PeerClientCount { get; set; }
    }
}
