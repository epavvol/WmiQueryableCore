using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_CheckCheck
    /// </summary>
    [WmiClass(Name = "Win32_CheckCheck")]
    public class Win32CheckCheck
    {
        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public object Location { get; set; }
    }
}