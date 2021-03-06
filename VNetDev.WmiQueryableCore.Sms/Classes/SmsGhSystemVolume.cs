using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_VOLUME
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_VOLUME")]
    public class SmsGhSystemVolume
    {
        /// <summary>
        /// WMI Property Access
        /// </summary>
        public uint Access { get; set; }
        /// <summary>
        /// WMI Property Automount
        /// </summary>
        public uint Automount { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property BlockSize
        /// </summary>
        public ulong BlockSize { get; set; }
        /// <summary>
        /// WMI Property Capacity
        /// </summary>
        public ulong Capacity { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property Compressed
        /// </summary>
        public uint Compressed { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public uint ConfigManagerUserConfig { get; set; }
        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DirtyBitSet
        /// </summary>
        public uint DirtyBitSet { get; set; }
        /// <summary>
        /// WMI Property DriveLetter
        /// </summary>
        public string DriveLetter { get; set; }
        /// <summary>
        /// WMI Property DriveType
        /// </summary>
        public uint DriveType { get; set; }
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
        /// WMI Property FileSystem
        /// </summary>
        public string FileSystem { get; set; }
        /// <summary>
        /// WMI Property FreeSpace
        /// </summary>
        public ulong FreeSpace { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IndexingEnabled
        /// </summary>
        public uint IndexingEnabled { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property Label
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property MaximumFileNameLength
        /// </summary>
        public uint MaximumFileNameLength { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberOfBlocks
        /// </summary>
        public ulong NumberOfBlocks { get; set; }
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
        /// WMI Property Purpose
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        /// WMI Property QuotasEnabled
        /// </summary>
        public uint QuotasEnabled { get; set; }
        /// <summary>
        /// WMI Property QuotasIncomplete
        /// </summary>
        public uint QuotasIncomplete { get; set; }
        /// <summary>
        /// WMI Property QuotasRebuilding
        /// </summary>
        public uint QuotasRebuilding { get; set; }
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
        public uint SerialNumber { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property StatusInfo
        /// </summary>
        public uint StatusInfo { get; set; }
        /// <summary>
        /// WMI Property SupportsDiskQuotas
        /// </summary>
        public uint SupportsDiskQuotas { get; set; }
        /// <summary>
        /// WMI Property SupportsFileBasedCompression
        /// </summary>
        public uint SupportsFileBasedCompression { get; set; }
        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }
        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
