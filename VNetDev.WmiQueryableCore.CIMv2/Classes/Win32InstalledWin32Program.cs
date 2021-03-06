using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_InstalledWin32Program
    /// </summary>
    [WmiClass(Name = "Win32_InstalledWin32Program")]
    public class Win32InstalledWin32Program
    {
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// WMI Property MsiPackageCode
        /// </summary>
        public string MsiPackageCode { get; set; }

        /// <summary>
        /// WMI Property MsiProductCode
        /// </summary>
        public string MsiProductCode { get; set; }

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