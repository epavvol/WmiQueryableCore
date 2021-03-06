using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_LogicalIdentity
    /// </summary>
    [WmiClass(Name = "CIM_LogicalIdentity")]
    public class CimLogicalIdentity
    {
        /// <summary>
        /// WMI Property SameElement
        /// </summary>
        public object SameElement { get; set; }

        /// <summary>
        /// WMI Property SystemElement
        /// </summary>
        public object SystemElement { get; set; }
    }
}