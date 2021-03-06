using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ProductProductDependency
    /// </summary>
    [WmiClass(Name = "CIM_ProductProductDependency")]
    public class CimProductProductDependency
    {
        /// <summary>
        /// WMI Property DependentProduct
        /// </summary>
        public object DependentProduct { get; set; }

        /// <summary>
        /// WMI Property RequiredProduct
        /// </summary>
        public object RequiredProduct { get; set; }

        /// <summary>
        /// WMI Property TypeOfDependency
        /// </summary>
        public ushort TypeOfDependency { get; set; }
    }
}