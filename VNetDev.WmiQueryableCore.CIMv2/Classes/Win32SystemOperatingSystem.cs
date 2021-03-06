using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SystemOperatingSystem
    /// </summary>
    [WmiClass(Name = "Win32_SystemOperatingSystem")]
    public class Win32SystemOperatingSystem
    {
        /// <summary>
        /// WMI Property GroupComponent
        /// </summary>
        public object GroupComponent { get; set; }

        /// <summary>
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }

        /// <summary>
        /// WMI Property PrimaryOS
        /// </summary>
        public bool PrimaryOs { get; set; }
    }
}