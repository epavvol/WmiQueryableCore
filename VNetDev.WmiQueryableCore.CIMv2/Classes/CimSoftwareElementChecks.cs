using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SoftwareElementChecks
    /// </summary>
    [WmiClass(Name = "CIM_SoftwareElementChecks")]
    public class CimSoftwareElementChecks
    {
        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Phase
        /// </summary>
        public ushort Phase { get; set; }
    }
}