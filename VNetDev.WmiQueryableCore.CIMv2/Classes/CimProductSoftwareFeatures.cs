using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ProductSoftwareFeatures
    /// </summary>
    [WmiClass(Name = "CIM_ProductSoftwareFeatures")]
    public class CimProductSoftwareFeatures
    {
        /// <summary>
        /// WMI Property Component
        /// </summary>
        public object Component { get; set; }

        /// <summary>
        /// WMI Property Product
        /// </summary>
        public object Product { get; set; }
    }
}