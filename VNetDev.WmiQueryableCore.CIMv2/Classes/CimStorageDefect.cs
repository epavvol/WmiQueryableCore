using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_StorageDefect
    /// </summary>
    [WmiClass(Name = "CIM_StorageDefect")]
    public class CimStorageDefect
    {
        /// <summary>
        /// WMI Property Error
        /// </summary>
        public object Error { get; set; }

        /// <summary>
        /// WMI Property Extent
        /// </summary>
        public object Extent { get; set; }
    }
}