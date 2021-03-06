using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PhysicalMemoryLocation
    /// </summary>
    [WmiClass(Name = "Win32_PhysicalMemoryLocation")]
    public class Win32PhysicalMemoryLocation
    {
        /// <summary>
        /// WMI Property GroupComponent
        /// </summary>
        public object GroupComponent { get; set; }

        /// <summary>
        /// WMI Property LocationWithinContainer
        /// </summary>
        public string LocationWithinContainer { get; set; }

        /// <summary>
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }
    }
}