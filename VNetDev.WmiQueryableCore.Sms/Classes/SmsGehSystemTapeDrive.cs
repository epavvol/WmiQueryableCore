using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_TAPE_DRIVE
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_TAPE_DRIVE")]
    public class SmsGehSystemTapeDrive
    {
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
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
        /// WMI Property Compression
        /// </summary>
        public uint Compression { get; set; }
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
        /// WMI Property ECC
        /// </summary>
        public uint Ecc { get; set; }
        /// <summary>
        /// WMI Property EOTWarningZoneSize
        /// </summary>
        public uint EotWarningZoneSize { get; set; }
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
        /// WMI Property FeaturesHigh
        /// </summary>
        public uint FeaturesHigh { get; set; }
        /// <summary>
        /// WMI Property FeaturesLow
        /// </summary>
        public uint FeaturesLow { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
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
        /// WMI Property MaxPartitionCount
        /// </summary>
        public uint MaxPartitionCount { get; set; }
        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public string MediaType { get; set; }
        /// <summary>
        /// WMI Property MinBlockSize
        /// </summary>
        public ulong MinBlockSize { get; set; }
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
        /// WMI Property Padding
        /// </summary>
        public uint Padding { get; set; }
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
        /// WMI Property ReportSetMarks
        /// </summary>
        public uint ReportSetMarks { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
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
    }
}
