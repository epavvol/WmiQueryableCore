using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_PhysicalElementLocation
    /// </summary>
    [WmiClass(Name = "CIM_PhysicalElementLocation")]
    public class CimPhysicalElementLocation
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property PhysicalLocation
        /// </summary>
        public object PhysicalLocation { get; set; }
    }
}