using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_TS_ISSUED_LICENSE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_TS_ISSUED_LICENSE")]
    public class SmsGehSystemTsIssuedLicense
    {
        /// <summary>
        /// WMI Property ExpirationDate
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IssueDate
        /// </summary>
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// WMI Property KeyPackId
        /// </summary>
        public uint KeyPackId { get; set; }
        /// <summary>
        /// WMI Property LicenseId
        /// </summary>
        public uint LicenseId { get; set; }
        /// <summary>
        /// WMI Property LicenseStatus
        /// </summary>
        public uint LicenseStatus { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property sHardwareId
        /// </summary>
        public string SHardwareId { get; set; }
        /// <summary>
        /// WMI Property sIssuedToComputer
        /// </summary>
        public string SIssuedToComputer { get; set; }
        /// <summary>
        /// WMI Property sIssuedToUser
        /// </summary>
        public string SIssuedToUser { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
