using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_MDM_RemoteFind
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_MDM_RemoteFind")]
    public class SmsGhSystemMdmRemoteFind
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Latitude
        /// </summary>
        public string Latitude { get; set; }
        /// <summary>
        /// WMI Property Longitude
        /// </summary>
        public string Longitude { get; set; }
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
