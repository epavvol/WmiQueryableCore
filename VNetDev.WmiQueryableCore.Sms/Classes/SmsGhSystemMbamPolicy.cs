using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_MBAM_POLICY
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_MBAM_POLICY")]
    public class SmsGhSystemMbamPolicy
    {
        /// <summary>
        /// WMI Property EncodedComputerName
        /// </summary>
        public string EncodedComputerName { get; set; }
        /// <summary>
        /// WMI Property EncryptionMethod
        /// </summary>
        public uint EncryptionMethod { get; set; }
        /// <summary>
        /// WMI Property FixedDataDriveAutoUnlock
        /// </summary>
        public uint FixedDataDriveAutoUnlock { get; set; }
        /// <summary>
        /// WMI Property FixedDataDriveEncryption
        /// </summary>
        public uint FixedDataDriveEncryption { get; set; }
        /// <summary>
        /// WMI Property FixedDataDrivePassphrase
        /// </summary>
        public uint FixedDataDrivePassphrase { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property KeyName
        /// </summary>
        public string KeyName { get; set; }
        /// <summary>
        /// WMI Property LastConsoleUser
        /// </summary>
        public string LastConsoleUser { get; set; }
        /// <summary>
        /// WMI Property MBAMMachineError
        /// </summary>
        public uint MbamMachineError { get; set; }
        /// <summary>
        /// WMI Property MBAMPolicyEnforced
        /// </summary>
        public uint MbamPolicyEnforced { get; set; }
        /// <summary>
        /// WMI Property OsDriveEncryption
        /// </summary>
        public uint OsDriveEncryption { get; set; }
        /// <summary>
        /// WMI Property OsDriveProtector
        /// </summary>
        public uint OsDriveProtector { get; set; }
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
        /// WMI Property UserExemptionDate
        /// </summary>
        public DateTime UserExemptionDate { get; set; }
    }
}
