using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_USER_PROFILE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_USER_PROFILE")]
    public class SmsGSystemUserProfile
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HealthStatus
        /// </summary>
        public uint HealthStatus { get; set; }
        /// <summary>
        /// WMI Property LastAttemptedProfileDownloadTime
        /// </summary>
        public string LastAttemptedProfileDownloadTime { get; set; }
        /// <summary>
        /// WMI Property LastAttemptedProfileUploadTime
        /// </summary>
        public string LastAttemptedProfileUploadTime { get; set; }
        /// <summary>
        /// WMI Property LastBackgroundRegistryUploadTime
        /// </summary>
        public string LastBackgroundRegistryUploadTime { get; set; }
        /// <summary>
        /// WMI Property LastDownloadTime
        /// </summary>
        public DateTime LastDownloadTime { get; set; }
        /// <summary>
        /// WMI Property LastUploadTime
        /// </summary>
        public DateTime LastUploadTime { get; set; }
        /// <summary>
        /// WMI Property LastUseTime
        /// </summary>
        public DateTime LastUseTime { get; set; }
        /// <summary>
        /// WMI Property Loaded
        /// </summary>
        public uint Loaded { get; set; }
        /// <summary>
        /// WMI Property LocalPath
        /// </summary>
        public string LocalPath { get; set; }
        /// <summary>
        /// WMI Property RefCount
        /// </summary>
        public uint RefCount { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property RoamingConfigured
        /// </summary>
        public uint RoamingConfigured { get; set; }
        /// <summary>
        /// WMI Property RoamingPath
        /// </summary>
        public string RoamingPath { get; set; }
        /// <summary>
        /// WMI Property RoamingPreference
        /// </summary>
        public uint RoamingPreference { get; set; }
        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// WMI Property Special
        /// </summary>
        public uint Special { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
