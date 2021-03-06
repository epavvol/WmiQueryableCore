using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectSecLimit
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectSecLimit")]
    public class Win32NamedJobObjectSecLimit
    {
        /// <summary>
        /// WMI Property Collection
        /// </summary>
        public object Collection { get; set; }

        /// <summary>
        /// WMI Property Setting
        /// </summary>
        public object Setting { get; set; }
    }
}