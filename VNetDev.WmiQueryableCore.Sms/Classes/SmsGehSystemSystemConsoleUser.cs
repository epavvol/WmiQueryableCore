using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SYSTEM_CONSOLE_USER
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SYSTEM_CONSOLE_USER")]
    public class SmsGehSystemSystemConsoleUser
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastConsoleUse
        /// </summary>
        public DateTime LastConsoleUse { get; set; }
        /// <summary>
        /// WMI Property NumberOfConsoleLogons
        /// </summary>
        public uint NumberOfConsoleLogons { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SystemConsoleUser
        /// </summary>
        public string SystemConsoleUser { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TotalUserConsoleMinutes
        /// </summary>
        public uint TotalUserConsoleMinutes { get; set; }
    }
}
