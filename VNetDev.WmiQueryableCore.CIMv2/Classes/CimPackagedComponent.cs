using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_PackagedComponent
    /// </summary>
    [WmiClass(Name = "CIM_PackagedComponent")]
    public class CimPackagedComponent
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
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }
    }
}