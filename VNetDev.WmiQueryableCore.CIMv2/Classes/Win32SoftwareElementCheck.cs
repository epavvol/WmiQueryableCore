using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SoftwareElementCheck
    /// </summary>
    [WmiClass(Name = "Win32_SoftwareElementCheck")]
    public class Win32SoftwareElementCheck
    {
        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Phase
        /// </summary>
        public ushort Phase { get; set; }
    }
}