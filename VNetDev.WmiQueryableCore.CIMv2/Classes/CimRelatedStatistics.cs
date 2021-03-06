using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_RelatedStatistics
    /// </summary>
    [WmiClass(Name = "CIM_RelatedStatistics")]
    public class CimRelatedStatistics
    {
        /// <summary>
        /// WMI Property RelatedStats
        /// </summary>
        public object RelatedStats { get; set; }

        /// <summary>
        /// WMI Property Stats
        /// </summary>
        public object Stats { get; set; }
    }
}