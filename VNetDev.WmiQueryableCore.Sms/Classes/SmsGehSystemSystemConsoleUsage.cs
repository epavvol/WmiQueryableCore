using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SYSTEM_CONSOLE_USAGE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SYSTEM_CONSOLE_USAGE")]
    public class SmsGehSystemSystemConsoleUsage
    {
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
        /// WMI Property SecurityLogStartDate
        /// </summary>
        public DateTime SecurityLogStartDate { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TopConsoleUser
        /// </summary>
        public string TopConsoleUser { get; set; }
        /// <summary>
        /// WMI Property TotalConsoleTime
        /// </summary>
        public uint TotalConsoleTime { get; set; }
        /// <summary>
        /// WMI Property TotalConsoleUsers
        /// </summary>
        public uint TotalConsoleUsers { get; set; }
        /// <summary>
        /// WMI Property TotalSecurityLogTime
        /// </summary>
        public uint TotalSecurityLogTime { get; set; }
    }
}
