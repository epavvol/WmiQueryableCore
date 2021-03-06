using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ImplementedCategory
    /// </summary>
    [WmiClass(Name = "Win32_ImplementedCategory")]
    public class Win32ImplementedCategory
    {
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public object Category { get; set; }

        /// <summary>
        /// WMI Property Component
        /// </summary>
        public object Component { get; set; }
    }
}