using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ElementCapacity
    /// </summary>
    [WmiClass(Name = "CIM_ElementCapacity")]
    public class CimElementCapacity
    {
        /// <summary>
        /// WMI Property Capacity
        /// </summary>
        public object Capacity { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }
    }
}