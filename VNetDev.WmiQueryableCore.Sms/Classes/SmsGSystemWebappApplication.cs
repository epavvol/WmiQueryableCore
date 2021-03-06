using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_WEBAPP_APPLICATION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_WEBAPP_APPLICATION")]
    public class SmsGSystemWebappApplication
    {
        /// <summary>
        /// WMI Property AppDeliveryTypeId
        /// </summary>
        public string AppDeliveryTypeId { get; set; }
        /// <summary>
        /// WMI Property AppDtRevision
        /// </summary>
        public uint AppDtRevision { get; set; }
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
        /// WMI Property TargetURL
        /// </summary>
        public string TargetUrl { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property URLFileName
        /// </summary>
        public string UrlFileName { get; set; }
        /// <summary>
        /// WMI Property URLPath
        /// </summary>
        public string UrlPath { get; set; }
        /// <summary>
        /// WMI Property UserSID
        /// </summary>
        public string UserSid { get; set; }
    }
}
