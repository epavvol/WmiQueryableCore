using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_VideoConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_VideoConfiguration")]
    public class Win32VideoConfiguration
    {
        /// <summary>
        /// WMI Property ActualColorResolution
        /// </summary>
        public uint ActualColorResolution { get; set; }

        /// <summary>
        /// WMI Property AdapterChipType
        /// </summary>
        public string AdapterChipType { get; set; }

        /// <summary>
        /// WMI Property AdapterCompatibility
        /// </summary>
        public string AdapterCompatibility { get; set; }

        /// <summary>
        /// WMI Property AdapterDACType
        /// </summary>
        public string AdapterDacType { get; set; }

        /// <summary>
        /// WMI Property AdapterDescription
        /// </summary>
        public string AdapterDescription { get; set; }

        /// <summary>
        /// WMI Property AdapterRAM
        /// </summary>
        public uint AdapterRam { get; set; }

        /// <summary>
        /// WMI Property AdapterType
        /// </summary>
        public string AdapterType { get; set; }

        /// <summary>
        /// WMI Property BitsPerPixel
        /// </summary>
        public uint BitsPerPixel { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ColorPlanes
        /// </summary>
        public uint ColorPlanes { get; set; }

        /// <summary>
        /// WMI Property ColorTableEntries
        /// </summary>
        public uint ColorTableEntries { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceSpecificPens
        /// </summary>
        public uint DeviceSpecificPens { get; set; }

        /// <summary>
        /// WMI Property DriverDate
        /// </summary>
        public DateTime DriverDate { get; set; }

        /// <summary>
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }

        /// <summary>
        /// WMI Property InfFilename
        /// </summary>
        public string InfFilename { get; set; }

        /// <summary>
        /// WMI Property InfSection
        /// </summary>
        public string InfSection { get; set; }

        /// <summary>
        /// WMI Property InstalledDisplayDrivers
        /// </summary>
        public string InstalledDisplayDrivers { get; set; }

        /// <summary>
        /// WMI Property MonitorManufacturer
        /// </summary>
        public string MonitorManufacturer { get; set; }

        /// <summary>
        /// WMI Property MonitorType
        /// </summary>
        public string MonitorType { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PixelsPerXLogicalInch
        /// </summary>
        public uint PixelsPerXLogicalInch { get; set; }

        /// <summary>
        /// WMI Property PixelsPerYLogicalInch
        /// </summary>
        public uint PixelsPerYLogicalInch { get; set; }

        /// <summary>
        /// WMI Property RefreshRate
        /// </summary>
        public uint RefreshRate { get; set; }

        /// <summary>
        /// WMI Property ScanMode
        /// </summary>
        public string ScanMode { get; set; }

        /// <summary>
        /// WMI Property ScreenHeight
        /// </summary>
        public uint ScreenHeight { get; set; }

        /// <summary>
        /// WMI Property ScreenWidth
        /// </summary>
        public uint ScreenWidth { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property SystemPaletteEntries
        /// </summary>
        public uint SystemPaletteEntries { get; set; }

        /// <summary>
        /// WMI Property VerticalResolution
        /// </summary>
        public uint VerticalResolution { get; set; }
    }
}