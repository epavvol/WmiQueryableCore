using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientBaseline
    /// </summary>
    [WmiClass(Name = "SMS_ClientBaseline")]
    public class SmsClientBaseline
    {
        /// <summary>
        /// WMI Property BaselineID
        /// </summary>
        public uint BaselineId { get; set; }
        /// <summary>
        /// WMI Property BaselineName
        /// </summary>
        public string BaselineName { get; set; }
        /// <summary>
        /// WMI Property BaselineType
        /// </summary>
        public uint BaselineType { get; set; }
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property LastUpdatedTime
        /// </summary>
        public DateTime LastUpdatedTime { get; set; }
        /// <summary>
        /// WMI Property SourceHash
        /// </summary>
        public string SourceHash { get; set; }
    }
}
