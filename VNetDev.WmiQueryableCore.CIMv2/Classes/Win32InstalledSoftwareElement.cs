using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_InstalledSoftwareElement
    /// </summary>
    [WmiClass(Name = "Win32_InstalledSoftwareElement")]
    public class Win32InstalledSoftwareElement
    {
        /// <summary>
        /// WMI Property Software
        /// </summary>
        public object Software { get; set; }

        /// <summary>
        /// WMI Property System
        /// </summary>
        public object System { get; set; }
    }
}