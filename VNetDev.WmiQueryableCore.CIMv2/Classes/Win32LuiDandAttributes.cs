using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_LUIDandAttributes
    /// </summary>
    [WmiClass(Name = "Win32_LUIDandAttributes")]
    public class Win32LuiDandAttributes
    {
        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public uint Attributes { get; set; }

        /// <summary>
        /// WMI Property LUID
        /// </summary>
        public object Luid { get; set; }
    }
}