using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectProcess
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectProcess")]
    public class Win32NamedJobObjectProcess
    {
        /// <summary>
        /// WMI Property Collection
        /// </summary>
        public object Collection { get; set; }

        /// <summary>
        /// WMI Property Member
        /// </summary>
        public object Member { get; set; }
    }
}