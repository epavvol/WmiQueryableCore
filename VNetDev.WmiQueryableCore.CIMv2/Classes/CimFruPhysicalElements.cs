using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_FRUPhysicalElements
    /// </summary>
    [WmiClass(Name = "CIM_FRUPhysicalElements")]
    public class CimFruPhysicalElements
    {
        /// <summary>
        /// WMI Property Component
        /// </summary>
        public object Component { get; set; }

        /// <summary>
        /// WMI Property FRU
        /// </summary>
        public object Fru { get; set; }
    }
}