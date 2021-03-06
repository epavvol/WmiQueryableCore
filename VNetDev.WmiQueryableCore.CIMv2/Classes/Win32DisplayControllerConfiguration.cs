using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DisplayControllerConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_DisplayControllerConfiguration")]
    public class Win32DisplayControllerConfiguration
    {
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
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceEntriesInAColorTable
        /// </summary>
        public uint DeviceEntriesInAColorTable { get; set; }

        /// <summary>
        /// WMI Property DeviceSpecificPens
        /// </summary>
        public uint DeviceSpecificPens { get; set; }

        /// <summary>
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property RefreshRate
        /// </summary>
        public int RefreshRate { get; set; }

        /// <summary>
        /// WMI Property ReservedSystemPaletteEntries
        /// </summary>
        public uint ReservedSystemPaletteEntries { get; set; }

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

        /// <summary>
        /// WMI Property VideoMode
        /// </summary>
        public string VideoMode { get; set; }
    }
}