using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_VIDEO_CONTROLLER
    /// </summary>
    [WmiClass(Name = "SMS_G_System_VIDEO_CONTROLLER")]
    public class SmsGSystemVideoController
    {
        /// <summary>
        /// WMI Property AcceleratorCapabilities
        /// </summary>
        public string AcceleratorCapabilities { get; set; }
        /// <summary>
        /// WMI Property AdapterCompatibility
        /// </summary>
        public string AdapterCompatibility { get; set; }
        /// <summary>
        /// WMI Property AdapterDACType
        /// </summary>
        public string AdapterDacType { get; set; }
        /// <summary>
        /// WMI Property AdapterRAM
        /// </summary>
        public uint AdapterRam { get; set; }
        /// <summary>
        /// WMI Property Availability
        /// </summary>
        public uint Availability { get; set; }
        /// <summary>
        /// WMI Property CapabilityDescriptions
        /// </summary>
        public string CapabilityDescriptions { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property ColorTableEntries
        /// </summary>
        public uint ColorTableEntries { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerErrorCode
        /// </summary>
        public uint ConfigManagerErrorCode { get; set; }
        /// <summary>
        /// WMI Property ConfigManagerUserConfig
        /// </summary>
        public uint ConfigManagerUserConfig { get; set; }
        /// <summary>
        /// WMI Property CurrentBitsPerPixel
        /// </summary>
        public uint CurrentBitsPerPixel { get; set; }
        /// <summary>
        /// WMI Property CurrentHorizontalResolution
        /// </summary>
        public uint CurrentHorizontalResolution { get; set; }
        /// <summary>
        /// WMI Property CurrentNumberOfColors
        /// </summary>
        public string CurrentNumberOfColors { get; set; }
        /// <summary>
        /// WMI Property CurrentNumberOfColumns
        /// </summary>
        public uint CurrentNumberOfColumns { get; set; }
        /// <summary>
        /// WMI Property CurrentNumberOfRows
        /// </summary>
        public uint CurrentNumberOfRows { get; set; }
        /// <summary>
        /// WMI Property CurrentRefreshRate
        /// </summary>
        public uint CurrentRefreshRate { get; set; }
        /// <summary>
        /// WMI Property CurrentScanMode
        /// </summary>
        public uint CurrentScanMode { get; set; }
        /// <summary>
        /// WMI Property CurrentVerticalResolution
        /// </summary>
        public uint CurrentVerticalResolution { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DeviceSpecificPens
        /// </summary>
        public string DeviceSpecificPens { get; set; }
        /// <summary>
        /// WMI Property DitherType
        /// </summary>
        public uint DitherType { get; set; }
        /// <summary>
        /// WMI Property DriverDate
        /// </summary>
        public DateTime DriverDate { get; set; }
        /// <summary>
        /// WMI Property DriverVersion
        /// </summary>
        public string DriverVersion { get; set; }
        /// <summary>
        /// WMI Property ErrorCleared
        /// </summary>
        public uint ErrorCleared { get; set; }
        /// <summary>
        /// WMI Property ErrorDescription
        /// </summary>
        public string ErrorDescription { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ICMIntent
        /// </summary>
        public uint IcmIntent { get; set; }
        /// <summary>
        /// WMI Property ICMMethod
        /// </summary>
        public uint IcmMethod { get; set; }
        /// <summary>
        /// WMI Property InfFilename
        /// </summary>
        public string InfFilename { get; set; }
        /// <summary>
        /// WMI Property InfSection
        /// </summary>
        public string InfSection { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property InstalledDisplayDrivers
        /// </summary>
        public string InstalledDisplayDrivers { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public uint LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property MaxMemorySupported
        /// </summary>
        public uint MaxMemorySupported { get; set; }
        /// <summary>
        /// WMI Property MaxNumberControlled
        /// </summary>
        public uint MaxNumberControlled { get; set; }
        /// <summary>
        /// WMI Property MaxRefreshRate
        /// </summary>
        public uint MaxRefreshRate { get; set; }
        /// <summary>
        /// WMI Property MinRefreshRate
        /// </summary>
        public uint MinRefreshRate { get; set; }
        /// <summary>
        /// WMI Property Monochrome
        /// </summary>
        public uint Monochrome { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NumberOfColorPlanes
        /// </summary>
        public uint NumberOfColorPlanes { get; set; }
        /// <summary>
        /// WMI Property NumberOfVideoPages
        /// </summary>
        public uint NumberOfVideoPages { get; set; }
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
        /// WMI Property ProtocolSupported
        /// </summary>
        public uint ProtocolSupported { get; set; }
        /// <summary>
        /// WMI Property ReservedSystemPaletteEntries
        /// </summary>
        public uint ReservedSystemPaletteEntries { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SpecificationVersion
        /// </summary>
        public uint SpecificationVersion { get; set; }
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
        /// WMI Property SystemPaletteEntries
        /// </summary>
        public uint SystemPaletteEntries { get; set; }
        /// <summary>
        /// WMI Property TimeOfLastReset
        /// </summary>
        public DateTime TimeOfLastReset { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property VideoArchitecture
        /// </summary>
        public uint VideoArchitecture { get; set; }
        /// <summary>
        /// WMI Property VideoMemoryType
        /// </summary>
        public uint VideoMemoryType { get; set; }
        /// <summary>
        /// WMI Property VideoMode
        /// </summary>
        public uint VideoMode { get; set; }
        /// <summary>
        /// WMI Property VideoModeDescription
        /// </summary>
        public string VideoModeDescription { get; set; }
        /// <summary>
        /// WMI Property VideoProcessor
        /// </summary>
        public string VideoProcessor { get; set; }
    }
}
