using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_CDROMDrive
    /// </summary>
    [WmiClass(Name = "Win32_CDROMDrive")]
    public class Win32CdromDrive
    {
        /// <summary>
        /// WMI method <c>Reset</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ResetDelegate();

        /// <summary>
        /// WMI method <c>SetPowerState</c> describing delegate.
        /// <param name="powerState">WMI Property <c>PowerState</c> of type <c>ushort</c>.</param>
        /// <param name="time">WMI Property <c>Time</c> of type <c>DateTime</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPowerStateDelegate(ushort powerState = default, DateTime time = default);

        /// <summary>
        /// WMI method <c>Reset</c>.
        /// </summary>
        public ResetDelegate Reset;

        /// <summary>
        /// WMI method <c>SetPowerState</c>.
        /// </summary>
        public SetPowerStateDelegate SetPowerState;

        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public ushort Availability { get; set; }

        /// <summary>
        /// WMI Property Capabilities
        /// </summary>
        public ICollection<ushort> Capabilities { get; set; }

        /// <summary>
        /// WMI Property CapabilityDescriptions
        /// </summary>
        public ICollection<string> CapabilityDescriptions { get; set; }

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
        public bool ConfigManagerUserConfig { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

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
        /// WMI Property Drive
        /// </summary>
        public string Drive { get; set; }

        /// <summary>
        /// WMI Property DriveIntegrity
        /// </summary>
        public bool DriveIntegrity { get; set; }

        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public bool ErrorCleared { get; set; }

        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// WMI Property ErrorMethodology
        /// </summary>
        public string ErrorMethodology { get; set; }

        /// <summary>
        /// WMI Property FileSystemFlags
        /// </summary>
        public ushort FileSystemFlags { get; set; }

        /// <summary>
        /// WMI Property FileSystemFlagsEx
        /// </summary>
        public uint FileSystemFlagsEx { get; set; }

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
        /// WMI Property MaximumComponentLength
        /// </summary>
        public uint MaximumComponentLength { get; set; }

        /// <summary>
        /// WMI Property MaxMediaSize
        /// </summary>
        public ulong MaxMediaSize { get; set; }

        /// <summary>
        /// WMI Property MediaLoaded
        /// </summary>
        public bool MediaLoaded { get; set; }

        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// WMI Property MfrAssignedRevisionLevel
        /// </summary>
        public string MfrAssignedRevisionLevel { get; set; }

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
        public bool NeedsCleaning { get; set; }

        /// <summary>
        /// WMI Property NumberOfMediaSupported
        /// </summary>
        public uint NumberOfMediaSupported { get; set; }

        /// <summary>
        /// WMI Property PNPDeviceID
        /// </summary>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// WMI Property PowerManagementCapabilities
        /// </summary>
        public ICollection<ushort> PowerManagementCapabilities { get; set; }

        /// <summary>
        /// WMI Property PowerManagementSupported
        /// </summary>
        public bool PowerManagementSupported { get; set; }

        /// <summary>
        /// WMI Property RevisionLevel
        /// </summary>
        public string RevisionLevel { get; set; }

        /// <summary>
        /// WMI Property SCSIBus
        /// </summary>
        public uint ScsiBus { get; set; }

        /// <summary>
        /// WMI Property SCSILogicalUnit
        /// </summary>
        public ushort ScsiLogicalUnit { get; set; }

        /// <summary>
        /// WMI Property SCSIPort
        /// </summary>
        public ushort ScsiPort { get; set; }

        /// <summary>
        /// WMI Property SCSITargetId
        /// </summary>
        public ushort ScsiTargetId { get; set; }

        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }

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
        public ushort StatusInfo { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property TransferRate
        /// </summary>
        public double TransferRate { get; set; }

        /// <summary>
        /// WMI Property VolumeName
        /// </summary>
        public string VolumeName { get; set; }

        /// <summary>
        /// WMI Property VolumeSerialNumber
        /// </summary>
        public string VolumeSerialNumber { get; set; }
    }
}