using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_FRU
    /// </summary>
    [WmiClass(Name = "CIM_FRU")]
    public class CimFru
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property FRUNumber
        /// </summary>
        public string FruNumber { get; set; }

        /// <summary>
        /// WMI Property IdentifyingNumber
        /// </summary>
        public string IdentifyingNumber { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property RevisionLevel
        /// </summary>
        public string RevisionLevel { get; set; }

        /// <summary>
        /// WMI Property Vendor
        /// </summary>
        public string Vendor { get; set; }
    }
}