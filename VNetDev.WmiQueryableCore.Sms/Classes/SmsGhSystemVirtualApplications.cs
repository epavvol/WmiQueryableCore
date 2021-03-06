using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_VIRTUAL_APPLICATIONS
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_VIRTUAL_APPLICATIONS")]
    public class SmsGhSystemVirtualApplications
    {
        /// <summary>
        /// WMI Property CachedOsdPath
        /// </summary>
        public string CachedOsdPath { get; set; }
        /// <summary>
        /// WMI Property GlobalRunningCount
        /// </summary>
        public uint GlobalRunningCount { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastLaunchOnSystem
        /// </summary>
        public DateTime LastLaunchOnSystem { get; set; }
        /// <summary>
        /// WMI Property Loading
        /// </summary>
        public uint Loading { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OriginalOsdPath
        /// </summary>
        public string OriginalOsdPath { get; set; }
        /// <summary>
        /// WMI Property PackageGUID
        /// </summary>
        public string PackageGuid { get; set; }
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
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
