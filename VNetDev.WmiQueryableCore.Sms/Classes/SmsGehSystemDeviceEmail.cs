using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_DEVICE_EMAIL
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_DEVICE_EMAIL")]
    public class SmsGehSystemDeviceEmail
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property OwnerEmailAddress
        /// </summary>
        public string OwnerEmailAddress { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SyncDomain
        /// </summary>
        public string SyncDomain { get; set; }
        /// <summary>
        /// WMI Property SyncServer
        /// </summary>
        public string SyncServer { get; set; }
        /// <summary>
        /// WMI Property SyncUser
        /// </summary>
        public string SyncUser { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public string Type { get; set; }
    }
}
