using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_CollectionOfMSEs
    /// </summary>
    [WmiClass(Name = "CIM_CollectionOfMSEs")]
    public class CimCollectionOfMsEs
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
    }
}