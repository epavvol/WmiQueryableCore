using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_DEVICE_ENCRYPTION
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_DEVICE_ENCRYPTION")]
    public class SmsGhSystemDeviceEncryption
    {
        /// <summary>
        /// WMI Property EmailEncryptionAlgorithm
        /// </summary>
        public uint EmailEncryptionAlgorithm { get; set; }
        /// <summary>
        /// WMI Property EmailEncryptionNegotiation
        /// </summary>
        public uint EmailEncryptionNegotiation { get; set; }
        /// <summary>
        /// WMI Property EmailEncryptionRequired
        /// </summary>
        public uint EmailEncryptionRequired { get; set; }
        /// <summary>
        /// WMI Property EmailSigningAlgorithm
        /// </summary>
        public uint EmailSigningAlgorithm { get; set; }
        /// <summary>
        /// WMI Property EmailSigningRequired
        /// </summary>
        public uint EmailSigningRequired { get; set; }
        /// <summary>
        /// WMI Property EncryptionCompliance
        /// </summary>
        public uint EncryptionCompliance { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property PhoneMemoryEncrypted
        /// </summary>
        public uint PhoneMemoryEncrypted { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property StorageCardEncrypted
        /// </summary>
        public uint StorageCardEncrypted { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
