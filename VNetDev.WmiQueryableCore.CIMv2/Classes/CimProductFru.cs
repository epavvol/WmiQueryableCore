using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ProductFRU
    /// </summary>
    [WmiClass(Name = "CIM_ProductFRU")]
    public class CimProductFru
    {
        /// <summary>
        /// WMI Property FRU
        /// </summary>
        public object Fru { get; set; }

        /// <summary>
        /// WMI Property Product
        /// </summary>
        public object Product { get; set; }
    }
}