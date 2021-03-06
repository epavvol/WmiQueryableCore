using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_AssociatedSupplyCurrentSensor
    /// </summary>
    [WmiClass(Name = "CIM_AssociatedSupplyCurrentSensor")]
    public class CimAssociatedSupplyCurrentSensor
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
        /// WMI Property MonitoringRange
        /// </summary>
        public ushort MonitoringRange { get; set; }
    }
}