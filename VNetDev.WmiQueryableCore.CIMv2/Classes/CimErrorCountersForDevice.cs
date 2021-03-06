using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ErrorCountersForDevice
    /// </summary>
    [WmiClass(Name = "CIM_ErrorCountersForDevice")]
    public class CimErrorCountersForDevice
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Stats
        /// </summary>
        public object Stats { get; set; }
    }
}