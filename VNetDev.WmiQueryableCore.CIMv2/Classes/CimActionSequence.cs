using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ActionSequence
    /// </summary>
    [WmiClass(Name = "CIM_ActionSequence")]
    public class CimActionSequence
    {
        /// <summary>
        /// WMI Property Next
        /// </summary>
        public object Next { get; set; }

        /// <summary>
        /// WMI Property Prior
        /// </summary>
        public object Prior { get; set; }
    }
}