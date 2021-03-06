using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_InstalledStoreProgram
    /// </summary>
    [WmiClass(Name = "Win32_InstalledStoreProgram")]
    public class Win32InstalledStoreProgram
    {
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ProgramId
        /// </summary>
        public string ProgramId { get; set; }

        /// <summary>
        /// WMI Property Vendor
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}