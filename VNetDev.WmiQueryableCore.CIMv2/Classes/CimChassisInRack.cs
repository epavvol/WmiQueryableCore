using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ChassisInRack
    /// </summary>
    [WmiClass(Name = "CIM_ChassisInRack")]
    public class CimChassisInRack
    {
        /// <summary>
        /// WMI Property BottomU
        /// </summary>
        public ushort BottomU { get; set; }

        /// <summary>
        /// WMI Property GroupComponent
        /// </summary>
        public object GroupComponent { get; set; }

        /// <summary>
        /// WMI Property LocationWithinContainer
        /// </summary>
        public string LocationWithinContainer { get; set; }

        /// <summary>
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }
    }
}