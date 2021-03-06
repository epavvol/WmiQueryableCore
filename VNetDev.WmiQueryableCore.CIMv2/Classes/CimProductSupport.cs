using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ProductSupport
    /// </summary>
    [WmiClass(Name = "CIM_ProductSupport")]
    public class CimProductSupport
    {
        /// <summary>
        /// WMI Property Product
        /// </summary>
        public object Product { get; set; }

        /// <summary>
        /// WMI Property Support
        /// </summary>
        public object Support { get; set; }
    }
}