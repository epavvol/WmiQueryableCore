using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SoftwareElementActions
    /// </summary>
    [WmiClass(Name = "CIM_SoftwareElementActions")]
    public class CimSoftwareElementActions
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public object Action { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }
    }
}