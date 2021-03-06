using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ProductResource
    /// </summary>
    [WmiClass(Name = "Win32_ProductResource")]
    public class Win32ProductResource
    {
        /// <summary>
        /// WMI Property Product
        /// </summary>
        public object Product { get; set; }

        /// <summary>
        /// WMI Property Resource
        /// </summary>
        public object Resource { get; set; }
    }
}