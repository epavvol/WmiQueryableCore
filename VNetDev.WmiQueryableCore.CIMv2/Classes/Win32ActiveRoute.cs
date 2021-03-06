using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ActiveRoute
    /// </summary>
    [WmiClass(Name = "Win32_ActiveRoute")]
    public class Win32ActiveRoute
    {
        /// <summary>
        /// WMI Property SameElement
        /// </summary>
        public object SameElement { get; set; }

        /// <summary>
        /// WMI Property SystemElement
        /// </summary>
        public object SystemElement { get; set; }
    }
}