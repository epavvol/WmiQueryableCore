using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_LUID
    /// </summary>
    [WmiClass(Name = "Win32_LUID")]
    public class Win32Luid
    {
        /// <summary>
        /// WMI Property HighPart
        /// </summary>
        public uint HighPart { get; set; }

        /// <summary>
        /// WMI Property LowPart
        /// </summary>
        public uint LowPart { get; set; }
    }
}