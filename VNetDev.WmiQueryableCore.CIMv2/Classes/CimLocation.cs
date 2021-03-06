using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Location
    /// </summary>
    [WmiClass(Name = "CIM_Location")]
    public class CimLocation
    {
        /// <summary>
        /// WMI Property Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PhysicalPosition
        /// </summary>
        public string PhysicalPosition { get; set; }
    }
}