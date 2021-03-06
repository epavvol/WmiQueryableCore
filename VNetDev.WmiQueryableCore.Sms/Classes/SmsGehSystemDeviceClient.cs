using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_DEVICE_CLIENT
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_DEVICE_CLIENT")]
    public class SmsGehSystemDeviceClient
    {
        /// <summary>
        /// WMI Property DownloadWhenRoaming
        /// </summary>
        public uint DownloadWhenRoaming { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SyncWhenRoaming
        /// </summary>
        public uint SyncWhenRoaming { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
