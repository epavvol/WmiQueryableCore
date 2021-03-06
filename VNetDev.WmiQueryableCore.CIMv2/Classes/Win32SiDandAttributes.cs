using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SIDandAttributes
    /// </summary>
    [WmiClass(Name = "Win32_SIDandAttributes")]
    public class Win32SiDandAttributes
    {
        /// <summary>
        /// WMI Property Attributes
        /// </summary>
        public uint Attributes { get; set; }

        /// <summary>
        /// WMI Property SID
        /// </summary>
        public object Sid { get; set; }
    }
}