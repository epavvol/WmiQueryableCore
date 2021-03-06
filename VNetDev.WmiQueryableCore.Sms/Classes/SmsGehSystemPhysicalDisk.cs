using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_PHYSICAL_DISK
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_PHYSICAL_DISK")]
    public class SmsGehSystemPhysicalDisk
    {
        /// <summary>
        /// WMI Property AllocatedSize
        /// </summary>
        public ulong AllocatedSize { get; set; }
        /// <summary>
        /// WMI Property BusType
        /// </summary>
        public uint BusType { get; set; }
        /// <summary>
        /// WMI Property CannotPoolReason
        /// </summary>
        public string CannotPoolReason { get; set; }
        /// <summary>
        /// WMI Property CanPool
        /// </summary>
        public uint CanPool { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceId
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property EnclosureNumber
        /// </summary>
        public uint EnclosureNumber { get; set; }
        /// <summary>
        /// WMI Property FirmwareVersion
        /// </summary>
        public string FirmwareVersion { get; set; }
        /// <summary>
        /// WMI Property FriendlyName
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HealthStatus
        /// </summary>
        public uint HealthStatus { get; set; }
        /// <summary>
        /// WMI Property IsIndicationEnabled
        /// </summary>
        public uint IsIndicationEnabled { get; set; }
        /// <summary>
        /// WMI Property IsPartial
        /// </summary>
        public uint IsPartial { get; set; }
        /// <summary>
        /// WMI Property LogicalSectorSize
        /// </summary>
        public ulong LogicalSectorSize { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public uint MediaType { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property ObjectId
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property OperationalStatus
        /// </summary>
        public string OperationalStatus { get; set; }
        /// <summary>
        /// WMI Property OtherCannotPoolReasonDescription
        /// </summary>
        public string OtherCannotPoolReasonDescription { get; set; }
        /// <summary>
        /// WMI Property PartNumber
        /// </summary>
        public string PartNumber { get; set; }
        /// <summary>
        /// WMI Property PhysicalLocation
        /// </summary>
        public string PhysicalLocation { get; set; }
        /// <summary>
        /// WMI Property PhysicalSectorSize
        /// </summary>
        public ulong PhysicalSectorSize { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public ulong Size { get; set; }
        /// <summary>
        /// WMI Property SlotNumber
        /// </summary>
        public uint SlotNumber { get; set; }
        /// <summary>
        /// WMI Property SoftwareVersion
        /// </summary>
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// WMI Property SpindleSpeed
        /// </summary>
        public uint SpindleSpeed { get; set; }
        /// <summary>
        /// WMI Property SupportedUsages
        /// </summary>
        public string SupportedUsages { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UniqueId
        /// </summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// WMI Property Usage
        /// </summary>
        public uint Usage { get; set; }
    }
}
