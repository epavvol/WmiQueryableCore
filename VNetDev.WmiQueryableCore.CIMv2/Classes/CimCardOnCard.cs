using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_CardOnCard
    /// </summary>
    [WmiClass(Name = "CIM_CardOnCard")]
    public class CimCardOnCard
    {
        /// <summary>
        /// WMI Property GroupComponent
        /// </summary>
        public object GroupComponent { get; set; }

        /// <summary>
        /// WMI Property LocationWithinContainer
        /// </summary>
        public string LocationWithinContainer { get; set; }

        /// <summary>
        /// WMI Property MountOrSlotDescription
        /// </summary>
        public string MountOrSlotDescription { get; set; }

        /// <summary>
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }
    }
}