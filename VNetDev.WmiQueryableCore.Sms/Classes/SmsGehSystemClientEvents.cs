using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_ClientEvents
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_ClientEvents")]
    public class SmsGehSystemClientEvents
    {
        /// <summary>
        /// WMI Property Count
        /// </summary>
        public uint Count { get; set; }
        /// <summary>
        /// WMI Property EventName
        /// </summary>
        public string EventName { get; set; }
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
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
