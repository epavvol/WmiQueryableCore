using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_WORKSTATION_STATUS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_WORKSTATION_STATUS")]
    public class SmsGSystemWorkstationStatus
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastHardwareScan
        /// </summary>
        public DateTime LastHardwareScan { get; set; }
        /// <summary>
        /// WMI Property LastReportVersion
        /// </summary>
        public string LastReportVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SystemDefaultLocaleID
        /// </summary>
        public uint SystemDefaultLocaleId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TimezoneOffset
        /// </summary>
        public uint TimezoneOffset { get; set; }
    }
}
