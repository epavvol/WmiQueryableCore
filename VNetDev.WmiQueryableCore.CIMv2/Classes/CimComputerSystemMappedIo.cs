using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ComputerSystemMappedIO
    /// </summary>
    [WmiClass(Name = "CIM_ComputerSystemMappedIO")]
    public class CimComputerSystemMappedIo
    {
        /// <summary>
        /// WMI Property GroupComponent
        /// </summary>
        public object GroupComponent { get; set; }

        /// <summary>
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }
    }
}