using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_WINDOWS8_APPLICATION_USER_INFO
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_WINDOWS8_APPLICATION_USER_INFO")]
    public class SmsGehSystemWindows8ApplicationUserInfo
    {
        /// <summary>
        /// WMI Property FullName
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstallState
        /// </summary>
        public string InstallState { get; set; }
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
        /// WMI Property UserAccountName
        /// </summary>
        public string UserAccountName { get; set; }
        /// <summary>
        /// WMI Property UserSecurityId
        /// </summary>
        public string UserSecurityId { get; set; }
    }
}
