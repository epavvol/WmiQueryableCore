using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectStatistics
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectStatistics")]
    public class Win32NamedJobObjectStatistics
    {
        /// <summary>
        /// WMI Property Collection
        /// </summary>
        public object Collection { get; set; }

        /// <summary>
        /// WMI Property Stats
        /// </summary>
        public object Stats { get; set; }
    }
}