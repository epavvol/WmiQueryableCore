using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ProductParentChild
    /// </summary>
    [WmiClass(Name = "CIM_ProductParentChild")]
    public class CimProductParentChild
    {
        /// <summary>
        /// WMI Property Child
        /// </summary>
        public object Child { get; set; }

        /// <summary>
        /// WMI Property Parent
        /// </summary>
        public object Parent { get; set; }
    }
}