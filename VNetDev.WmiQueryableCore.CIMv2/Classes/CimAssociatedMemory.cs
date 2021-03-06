using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_AssociatedMemory
    /// </summary>
    [WmiClass(Name = "CIM_AssociatedMemory")]
    public class CimAssociatedMemory
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