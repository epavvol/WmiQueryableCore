using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SYSTEMBOOTDATA
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SYSTEMBOOTDATA")]
    public class SmsGSystemSystembootdata
    {
        /// <summary>
        /// WMI Property BiosDuration
        /// </summary>
        public uint BiosDuration { get; set; }
        /// <summary>
        /// WMI Property BootDiskMediaType
        /// </summary>
        public uint BootDiskMediaType { get; set; }
        /// <summary>
        /// WMI Property BootDuration
        /// </summary>
        public uint BootDuration { get; set; }
        /// <summary>
        /// WMI Property EventLogStart
        /// </summary>
        public uint EventLogStart { get; set; }
        /// <summary>
        /// WMI Property GPDuration
        /// </summary>
        public uint GpDuration { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property OSVersion
        /// </summary>
        public string OsVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SystemStartTime
        /// </summary>
        public ulong SystemStartTime { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UpdateDuration
        /// </summary>
        public uint UpdateDuration { get; set; }
    }
}
