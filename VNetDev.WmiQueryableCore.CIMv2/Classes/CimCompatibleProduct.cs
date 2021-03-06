using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_CompatibleProduct
    /// </summary>
    [WmiClass(Name = "CIM_CompatibleProduct")]
    public class CimCompatibleProduct
    {
        /// <summary>
        /// WMI Property CompatibilityDescription
        /// </summary>
        public string CompatibilityDescription { get; set; }

        /// <summary>
        /// WMI Property CompatibleProduct
        /// </summary>
        public object CompatibleProduct { get; set; }

        /// <summary>
        /// WMI Property Product
        /// </summary>
        public object Product { get; set; }
    }
}