using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_TPM_STATUS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_TPM_STATUS")]
    public class SmsGSystemTpmStatus
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Information
        /// </summary>
        public uint Information { get; set; }
        /// <summary>
        /// WMI Property IsApplicable
        /// </summary>
        public uint IsApplicable { get; set; }
        /// <summary>
        /// WMI Property IsReady
        /// </summary>
        public uint IsReady { get; set; }
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
