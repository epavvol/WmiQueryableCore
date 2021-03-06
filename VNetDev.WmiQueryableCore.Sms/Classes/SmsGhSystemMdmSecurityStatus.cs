using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_MDM_SecurityStatus
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_MDM_SecurityStatus")]
    public class SmsGhSystemMdmSecurityStatus
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HardwareEncryptionCaps
        /// </summary>
        public uint HardwareEncryptionCaps { get; set; }
        /// <summary>
        /// WMI Property PasscodeCompliant
        /// </summary>
        public uint PasscodeCompliant { get; set; }
        /// <summary>
        /// WMI Property PasscodeCompliantWithProfiles
        /// </summary>
        public uint PasscodeCompliantWithProfiles { get; set; }
        /// <summary>
        /// WMI Property PasscodePresent
        /// </summary>
        public uint PasscodePresent { get; set; }
        /// <summary>
        /// WMI Property RequireEncryption
        /// </summary>
        public uint RequireEncryption { get; set; }
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
