using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ShareToDirectory
    /// </summary>
    [WmiClass(Name = "Win32_ShareToDirectory")]
    public class Win32ShareToDirectory
    {
        /// <summary>
        /// WMI Property Share
        /// </summary>
        public object Share { get; set; }

        /// <summary>
        /// WMI Property SharedElement
        /// </summary>
        public object SharedElement { get; set; }
    }
}