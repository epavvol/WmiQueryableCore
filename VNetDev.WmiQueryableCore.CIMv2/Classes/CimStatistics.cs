using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Statistics
    /// </summary>
    [WmiClass(Name = "CIM_Statistics")]
    public class CimStatistics
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Stats
        /// </summary>
        public object Stats { get; set; }
    }
}