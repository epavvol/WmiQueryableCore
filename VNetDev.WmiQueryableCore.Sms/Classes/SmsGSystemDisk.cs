using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_DISK
    /// </summary>
    [WmiClass(Name = "SMS_G_System_DISK")]
    public class SmsGSystemDisk
    {
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property BytesPerSector
        /// </summary>
        public uint BytesPerSector { get; set; }
        /// <summary>
        /// WMI Property Capabilities
        /// </summary>
        public string Capabilities { get; set; }
        /// <summary>
        /// WMI Property CapabilityDescriptions
        /// </summary>
        public string CapabilityDescriptions { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property CompressionMethod
        /// </summary>
        public string CompressionMethod { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public uint ConfigManagerUserConfig { get; set; }
        /// <summary>
        /// WMI Property DefaultBlockSize
        /// </summary>
        public ulong DefaultBlockSize { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public uint ErrorCleared { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property ErrorMethodology
        /// </summary>
        public string ErrorMethodology { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property InterfaceType
        /// </summary>
        public string InterfaceType { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property Manufacturer
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// WMI Property MaxBlockSize
        /// </summary>
        public ulong MaxBlockSize { get; set; }
        /// <summary>
        /// WMI Property MaxMediaSize
        /// </summary>
        public ulong MaxMediaSize { get; set; }
        /// <summary>
        /// WMI Property MediaLoaded
        /// </summary>
        public uint MediaLoaded { get; set; }
        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public string MediaType { get; set; }
        /// <summary>
        /// WMI Property MinBlockSize
        /// </summary>
        public ulong MinBlockSize { get; set; }
        /// <summary>
        /// WMI Property Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NeedsCleaning
        /// </summary>
        public uint NeedsCleaning { get; set; }
        /// <summary>
        /// WMI Property NumberOfMediaSupported
        /// </summary>
        public uint NumberOfMediaSupported { get; set; }
        /// <summary>
        /// WMI Property Partitions
        /// </summary>
        public uint Partitions { get; set; }
        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }
        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public string PowerManagementCapabilities { get; set; }
        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public uint PowerManagementSupported { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SCSIBus
        /// </summary>
        public uint ScsiBus { get; set; }
        /// <summary>
        /// WMI Property SCSILogicalUnit
        /// </summary>
        public uint ScsiLogicalUnit { get; set; }
        /// <summary>
        /// WMI Property SCSIPort
        /// </summary>
        public uint ScsiPort { get; set; }
        /// <summary>
        /// WMI Property SCSITargetId
        /// </summary>
        public uint ScsiTargetId { get; set; }
        /// <summary>
        /// WMI Property SectorsPerTrack
        /// </summary>
        public uint SectorsPerTrack { get; set; }
        /// <summary>
        /// WMI Property Size
        /// </summary>
        public ulong Size { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property TotalCylinders
        /// </summary>
        public string TotalCylinders { get; set; }
        /// <summary>
        /// WMI Property TotalHeads
        /// </summary>
        public uint TotalHeads { get; set; }
        /// <summary>
        /// WMI Property TotalSectors
        /// </summary>
        public string TotalSectors { get; set; }
        /// <summary>
        /// WMI Property TotalTracks
        /// </summary>
        public string TotalTracks { get; set; }
        /// <summary>
        /// WMI Property TracksPerCylinder
        /// </summary>
        public uint TracksPerCylinder { get; set; }
    }
}
