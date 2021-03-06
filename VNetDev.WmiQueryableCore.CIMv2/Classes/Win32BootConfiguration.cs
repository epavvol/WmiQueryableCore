using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_BootConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_BootConfiguration")]
    public class Win32BootConfiguration
    {
        /// <summary>
        /// WMI Property BootDirectory
        /// </summary>
        public string BootDirectory { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ConfigurationPath
        /// </summary>
        public string ConfigurationPath { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property LastDrive
        /// </summary>
        public string LastDrive { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ScratchDirectory
        /// </summary>
        public string ScratchDirectory { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property TempDirectory
        /// </summary>
        public string TempDirectory { get; set; }
    }
}