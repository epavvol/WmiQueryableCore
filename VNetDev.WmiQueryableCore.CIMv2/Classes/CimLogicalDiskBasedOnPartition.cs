using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_LogicalDiskBasedOnPartition
    /// </summary>
    [WmiClass(Name = "CIM_LogicalDiskBasedOnPartition")]
    public class CimLogicalDiskBasedOnPartition
    {
        /// <summary>
        /// WMI Property Antecedent
        /// </summary>
        public object Antecedent { get; set; }

        /// <summary>
        /// WMI Property Dependent
        /// </summary>
        public object Dependent { get; set; }

        /// <summary>
        /// WMI Property EndingAddress
        /// </summary>
        public ulong EndingAddress { get; set; }

        /// <summary>
        /// WMI Property StartingAddress
        /// </summary>
        public ulong StartingAddress { get; set; }
    }
}