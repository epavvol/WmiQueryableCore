using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_BitLockerEncryptionDetails
    /// </summary>
    [WmiClass(Name = "Win32_BitLockerEncryptionDetails")]
    public class Win32BitLockerEncryptionDetails
    {
        /// <summary>
        /// WMI Property BitlockerPersistentVolumeId
        /// </summary>
        public string BitlockerPersistentVolumeId { get; set; }

        /// <summary>
        /// WMI Property Compliant
        /// </summary>
        public int Compliant { get; set; }

        /// <summary>
        /// WMI Property ConversionStatus
        /// </summary>
        public int ConversionStatus { get; set; }

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
        public int EncryptionMethod { get; set; }

        /// <summary>
        /// WMI Property EnforcePolicyDate
        /// </summary>
        public string EnforcePolicyDate { get; set; }

        /// <summary>
        /// WMI Property IsAutoUnlockEnabled
        /// </summary>
        public bool IsAutoUnlockEnabled { get; set; }

        /// <summary>
        /// WMI Property KeyProtectorTypes
        /// </summary>
        public ICollection<int> KeyProtectorTypes { get; set; }

        /// <summary>
        /// WMI Property MbamPersistentVolumeId
        /// </summary>
        public string MbamPersistentVolumeId { get; set; }

        /// <summary>
        /// WMI Property MbamVolumeType
        /// </summary>
        public int MbamVolumeType { get; set; }

        /// <summary>
        /// WMI Property NoncomplianceDetectedDate
        /// </summary>
        public string NoncomplianceDetectedDate { get; set; }

        /// <summary>
        /// WMI Property ProtectionStatus
        /// </summary>
        public int ProtectionStatus { get; set; }

        /// <summary>
        /// WMI Property ReasonsForNonCompliance
        /// </summary>
        public ICollection<int> ReasonsForNonCompliance { get; set; }
    }
}