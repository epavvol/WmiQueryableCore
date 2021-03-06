using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Product
    /// </summary>
    [WmiClass(Name = "CIM_Product")]
    public class CimProduct
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property IdentifyingNumber
        /// </summary>
        public string IdentifyingNumber { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SKUNumber
        /// </summary>
        public string SkuNumber { get; set; }

        /// <summary>
        /// WMI Property UUID
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// WMI Property Vendor
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}