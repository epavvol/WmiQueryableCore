using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_CollectionStatistics
    /// </summary>
    [WmiClass(Name = "Win32_CollectionStatistics")]
    public class Win32CollectionStatistics
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