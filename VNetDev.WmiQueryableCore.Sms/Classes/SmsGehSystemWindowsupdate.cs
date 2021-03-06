using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_WINDOWSUPDATE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_WINDOWSUPDATE")]
    public class SmsGehSystemWindowsupdate
    {
        /// <summary>
        /// WMI Property AUOptions
        /// </summary>
        public uint AuOptions { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstanceKey
        /// </summary>
        public string InstanceKey { get; set; }
        /// <summary>
        /// WMI Property NoAutoUpdate
        /// </summary>
        public uint NoAutoUpdate { get; set; }
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
        /// <summary>
        /// WMI Property UseWUServer
        /// </summary>
        public uint UseWuServer { get; set; }
    }
}
