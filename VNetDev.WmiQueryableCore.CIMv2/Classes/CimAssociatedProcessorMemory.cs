using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_AssociatedProcessorMemory
    /// </summary>
    [WmiClass(Name = "CIM_AssociatedProcessorMemory")]
    public class CimAssociatedProcessorMemory
    {
        /// <summary>
        /// WMI Property Antecedent
        /// </summary>
        public object Antecedent { get; set; }

        /// <summary>
        /// WMI Property BusSpeed
        /// </summary>
        public uint BusSpeed { get; set; }

        /// <summary>
        /// WMI Property Dependent
        /// </summary>
        public object Dependent { get; set; }
    }
}