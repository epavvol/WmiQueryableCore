using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectLimit
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectLimit")]
    public class Win32NamedJobObjectLimit
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