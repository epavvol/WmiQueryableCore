using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_ACTIVESYNC_CONNECTED_DEVICE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_ACTIVESYNC_CONNECTED_DEVICE")]
    public class SmsGSystemActivesyncConnectedDevice
    {
        /// <summary>
        /// WMI Property DeviceOEMInfo
        /// </summary>
        public string DeviceOemInfo { get; set; }
        /// <summary>
        /// WMI Property DeviceType
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstalledClientID
        /// </summary>
        public string InstalledClientId { get; set; }
        /// <summary>
        /// WMI Property InstalledClientServer
        /// </summary>
        public string InstalledClientServer { get; set; }
        /// <summary>
        /// WMI Property InstalledClientVersion
        /// </summary>
        public string InstalledClientVersion { get; set; }
        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public string LastSyncTime { get; set; }
        /// <summary>
        /// WMI Property OS_AdditionalInfo
        /// </summary>
        [WmiProperty(Name = "OS_AdditionalInfo")]
        public string OsAdditionalInfo { get; set; }
        /// <summary>
        /// WMI Property OS_Build
        /// </summary>
        [WmiProperty(Name = "OS_Build")]
        public string OsBuild { get; set; }
        /// <summary>
        /// WMI Property OS_Major
        /// </summary>
        [WmiProperty(Name = "OS_Major")]
        public string OsMajor { get; set; }
        /// <summary>
        /// WMI Property OS_Minor
        /// </summary>
        [WmiProperty(Name = "OS_Minor")]
        public string OsMinor { get; set; }
        /// <summary>
        /// WMI Property OS_Platform
        /// </summary>
        [WmiProperty(Name = "OS_Platform")]
        public string OsPlatform { get; set; }
        /// <summary>
        /// WMI Property ProcessorArchitecture
        /// </summary>
        public string ProcessorArchitecture { get; set; }
        /// <summary>
        /// WMI Property ProcessorLevel
        /// </summary>
        public string ProcessorLevel { get; set; }
        /// <summary>
        /// WMI Property ProcessorRevision
        /// </summary>
        public string ProcessorRevision { get; set; }
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
