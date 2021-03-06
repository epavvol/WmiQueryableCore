using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DEVICE_MEMORY
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DEVICE_MEMORY")]
    public class SmsGSystemDeviceMemory
    {
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ProgramFree
        /// </summary>
        public ulong ProgramFree { get; set; }
        /// <summary>
        /// WMI Property ProgramTotal
        /// </summary>
        public ulong ProgramTotal { get; set; }
        /// <summary>
        /// WMI Property RemovableStorageFree
        /// </summary>
        public ulong RemovableStorageFree { get; set; }
        /// <summary>
        /// WMI Property RemovableStorageTotal
        /// </summary>
        public ulong RemovableStorageTotal { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property StorageFree
        /// </summary>
        public ulong StorageFree { get; set; }
        /// <summary>
        /// WMI Property StorageTotal
        /// </summary>
        public ulong StorageTotal { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
