using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_FRUIncludesProduct
    /// </summary>
    [WmiClass(Name = "CIM_FRUIncludesProduct")]
    public class CimFruIncludesProduct
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