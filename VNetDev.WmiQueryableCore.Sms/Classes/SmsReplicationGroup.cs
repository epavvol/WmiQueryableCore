using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ReplicationGroup
    /// </summary>
    [WmiClass(Name = "SMS_ReplicationGroup")]
    public class SmsReplicationGroup
    {
        /// <summary>
        /// WMI static method <c>InitializeData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="replicationGroupId">WMI Property <c>ReplicationGroupID</c> of type <c>uint</c>.</param>
        /// <param name="siteCode1">WMI Property <c>SiteCode1</c> of type <c>string</c>.</param>
        /// <param name="siteCode2">WMI Property <c>SiteCode2</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InitializeDataDelegate(WmiContext wmiContext, uint replicationGroupId = default, string siteCode1 = default, string siteCode2 = default);
        /// <summary>
        /// WMI static method <c>InitializeData</c>.
        /// </summary>
        public static InitializeDataDelegate InitializeData;
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsPush
        /// </summary>
        public bool IsPush { get; set; }
        /// <summary>
        /// WMI Property ReplicationGroup
        /// </summary>
        public string ReplicationGroup { get; set; }
        /// <summary>
        /// WMI Property ReplicationPattern
        /// </summary>
        public string ReplicationPattern { get; set; }
        /// <summary>
        /// WMI Property ReplicationPriority
        /// </summary>
        public ushort ReplicationPriority { get; set; }
        /// <summary>
        /// WMI Property SecurityKey
        /// </summary>
        public string SecurityKey { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property SyncInterval
        /// </summary>
        public uint SyncInterval { get; set; }
        /// <summary>
        /// WMI Property TransportType
        /// </summary>
        public string TransportType { get; set; }
    }
}
