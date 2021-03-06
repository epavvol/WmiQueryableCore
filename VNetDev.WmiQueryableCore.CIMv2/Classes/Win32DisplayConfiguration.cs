using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DisplayConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_DisplayConfiguration")]
    public class Win32DisplayConfiguration
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
        public string DriverVersion { get; set; }

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
        /// WMI Property PelsHeight
        /// </summary>
        public uint PelsHeight { get; set; }

        /// <summary>
        /// WMI Property PelsWidth
        /// </summary>
        public uint PelsWidth { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property SpecificationVersion
        /// </summary>
        public uint SpecificationVersion { get; set; }
    }
}