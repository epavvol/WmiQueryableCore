using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PrinterConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_PrinterConfiguration")]
    public class Win32PrinterConfiguration
    {
        /// <summary>
        /// WMI Property BitsPerPel
        /// </summary>
        public uint BitsPerPel { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Collate
        /// </summary>
        public bool Collate { get; set; }

        /// <summary>
        /// WMI Property Color
        /// </summary>
        public uint Color { get; set; }

        /// <summary>
        /// WMI Property Copies
        /// </summary>
        public uint Copies { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// WMI Property DisplayFlags
        /// </summary>
        public uint DisplayFlags { get; set; }

        /// <summary>
        /// WMI Property DisplayFrequency
        /// </summary>
        public uint DisplayFrequency { get; set; }

        /// <summary>
        /// WMI Property DitherType
        /// </summary>
        public uint DitherType { get; set; }

        /// <summary>
        /// WMI Property DriverVersion
        /// </summary>
        public uint DriverVersion { get; set; }

        /// <summary>
        /// WMI Property Duplex
        /// </summary>
        public bool Duplex { get; set; }

        /// <summary>
        /// WMI Property FormName
        /// </summary>
        public string FormName { get; set; }

        /// <summary>
        /// WMI Property HorizontalResolution
        /// </summary>
        public uint HorizontalResolution { get; set; }

        /// <summary>
        /// WMI Property ICMIntent
        /// </summary>
        public uint IcmIntent { get; set; }

        /// <summary>
        /// WMI Property ICMMethod
        /// </summary>
        public uint IcmMethod { get; set; }

        /// <summary>
        /// WMI Property LogPixels
        /// </summary>
        public uint LogPixels { get; set; }

        /// <summary>
        /// WMI Property MediaType
        /// </summary>
        public uint MediaType { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Orientation
        /// </summary>
        public uint Orientation { get; set; }

        /// <summary>
        /// WMI Property PaperLength
        /// </summary>
        public uint PaperLength { get; set; }

        /// <summary>
        /// WMI Property PaperSize
        /// </summary>
        public string PaperSize { get; set; }

        /// <summary>
        /// WMI Property PaperWidth
        /// </summary>
        public uint PaperWidth { get; set; }

        /// <summary>
        /// WMI Property PelsHeight
        /// </summary>
        public uint PelsHeight { get; set; }

        /// <summary>
        /// WMI Property PelsWidth
        /// </summary>
        public uint PelsWidth { get; set; }

        /// <summary>
        /// WMI Property PrintQuality
        /// </summary>
        public uint PrintQuality { get; set; }

        /// <summary>
        /// WMI Property Scale
        /// </summary>
        public uint Scale { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property SpecificationVersion
        /// </summary>
        public uint SpecificationVersion { get; set; }

        /// <summary>
        /// WMI Property TTOption
        /// </summary>
        public uint TtOption { get; set; }

        /// <summary>
        /// WMI Property VerticalResolution
        /// </summary>
        public uint VerticalResolution { get; set; }

        /// <summary>
        /// WMI Property XResolution
        /// </summary>
        public uint XResolution { get; set; }

        /// <summary>
        /// WMI Property YResolution
        /// </summary>
        public uint YResolution { get; set; }
    }
}