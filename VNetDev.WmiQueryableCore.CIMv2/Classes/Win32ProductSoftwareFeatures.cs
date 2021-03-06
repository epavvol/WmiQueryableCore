using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ProductSoftwareFeatures
    /// </summary>
    [WmiClass(Name = "Win32_ProductSoftwareFeatures")]
    public class Win32ProductSoftwareFeatures
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