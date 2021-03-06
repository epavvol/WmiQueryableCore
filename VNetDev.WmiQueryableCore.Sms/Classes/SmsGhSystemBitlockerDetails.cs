using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_BITLOCKER_DETAILS
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_BITLOCKER_DETAILS")]
    public class SmsGhSystemBitlockerDetails
    {
        /// <summary>
        /// WMI Property BitlockerPersistentVolumeId
        /// </summary>
        public string BitlockerPersistentVolumeId { get; set; }
        /// <summary>
        /// WMI Property Compliant
        /// </summary>
        public uint Compliant { get; set; }
        /// <summary>
        /// WMI Property ConversionStatus
        /// </summary>
        public uint ConversionStatus { get; set; }
        /// <summary>
        /// WMI Property DeviceId
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DriveLetter
        /// </summary>
        public string DriveLetter { get; set; }
        /// <summary>
        /// WMI Property EncryptionMethod
        /// </summary>
        public uint EncryptionMethod { get; set; }
        /// <summary>
        /// WMI Property EnforcePolicyDate
        /// </summary>
        public string EnforcePolicyDate { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsAutoUnlockEnabled
        /// </summary>
        public uint IsAutoUnlockEnabled { get; set; }
        /// <summary>
        /// WMI Property KeyProtectorTypes
        /// </summary>
        public string KeyProtectorTypes { get; set; }
        /// <summary>
        /// WMI Property MbamPersistentVolumeId
        /// </summary>
        public string MbamPersistentVolumeId { get; set; }
        /// <summary>
        /// WMI Property MbamVolumeType
        /// </summary>
        public uint MbamVolumeType { get; set; }
        /// <summary>
        /// WMI Property NoncomplianceDetectedDate
        /// </summary>
        public string NoncomplianceDetectedDate { get; set; }
        /// <summary>
        /// WMI Property ProtectionStatus
        /// </summary>
        public uint ProtectionStatus { get; set; }
        /// <summary>
        /// WMI Property ReasonsForNonCompliance
        /// </summary>
        public string ReasonsForNonCompliance { get; set; }
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
