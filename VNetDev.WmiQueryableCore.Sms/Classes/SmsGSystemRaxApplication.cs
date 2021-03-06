using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_RAX_APPLICATION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_RAX_APPLICATION")]
    public class SmsGSystemRaxApplication
    {
        /// <summary>
        /// WMI Property AppID
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// WMI Property FeedURL
        /// </summary>
        public string FeedUrl { get; set; }
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
        /// <summary>
        /// WMI Property UserSID
        /// </summary>
        public string UserSid { get; set; }
    }
}
