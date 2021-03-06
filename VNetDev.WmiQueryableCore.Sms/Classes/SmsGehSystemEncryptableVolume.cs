using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_ENCRYPTABLE_VOLUME
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_ENCRYPTABLE_VOLUME")]
    public class SmsGehSystemEncryptableVolume
    {
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DriveLetter
        /// </summary>
        public string DriveLetter { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property PersistentVolumeID
        /// </summary>
        public string PersistentVolumeId { get; set; }
        /// <summary>
        /// WMI Property ProtectionStatus
        /// </summary>
        public uint ProtectionStatus { get; set; }
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
