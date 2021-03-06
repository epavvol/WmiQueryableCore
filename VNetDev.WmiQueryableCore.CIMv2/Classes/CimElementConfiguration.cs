using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ElementConfiguration
    /// </summary>
    [WmiClass(Name = "CIM_ElementConfiguration")]
    public class CimElementConfiguration
    {
        /// <summary>
        /// WMI Property Configuration
        /// </summary>
        public object Configuration { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }
    }
}