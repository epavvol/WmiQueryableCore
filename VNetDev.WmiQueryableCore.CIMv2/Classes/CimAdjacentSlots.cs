using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_AdjacentSlots
    /// </summary>
    [WmiClass(Name = "CIM_AdjacentSlots")]
    public class CimAdjacentSlots
    {
        /// <summary>
        /// WMI Property DistanceBetweenSlots
        /// </summary>
        public float DistanceBetweenSlots { get; set; }

        /// <summary>
        /// WMI Property SharedSlots
        /// </summary>
        public bool SharedSlots { get; set; }

        /// <summary>
        /// WMI Property SlotA
        /// </summary>
        public object SlotA { get; set; }

        /// <summary>
        /// WMI Property SlotB
        /// </summary>
        public object SlotB { get; set; }
    }
}