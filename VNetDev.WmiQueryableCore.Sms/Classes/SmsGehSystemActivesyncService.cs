using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_ACTIVESYNC_SERVICE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_ACTIVESYNC_SERVICE")]
    public class SmsGehSystemActivesyncService
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public string LastSyncTime { get; set; }
        /// <summary>
        /// WMI Property MajorVersion
        /// </summary>
        public uint MajorVersion { get; set; }
        /// <summary>
        /// WMI Property MinorVersion
        /// </summary>
        public uint MinorVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
