using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_VIRTUAL_APPLICATION_PACKAGES
    /// </summary>
    [WmiClass(Name = "SMS_G_System_VIRTUAL_APPLICATION_PACKAGES")]
    public class SmsGSystemVirtualApplicationPackages
    {
        /// <summary>
        /// WMI Property CachedLaunchSize
        /// </summary>
        public ulong CachedLaunchSize { get; set; }
        /// <summary>
        /// WMI Property CachedPercentage
        /// </summary>
        public uint CachedPercentage { get; set; }
        /// <summary>
        /// WMI Property CachedSize
        /// </summary>
        public ulong CachedSize { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LaunchSize
        /// </summary>
        public ulong LaunchSize { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
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
        /// WMI Property SftPath
        /// </summary>
        public string SftPath { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TotalSize
        /// </summary>
        public ulong TotalSize { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VersionGUID
        /// </summary>
        public string VersionGuid { get; set; }
    }
}
