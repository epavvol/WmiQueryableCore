using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_CollectedCollections
    /// </summary>
    [WmiClass(Name = "CIM_CollectedCollections")]
    public class CimCollectedCollections
    {
        /// <summary>
        /// WMI Property Collection
        /// </summary>
        public object Collection { get; set; }

        /// <summary>
        /// WMI Property CollectionInCollection
        /// </summary>
        public object CollectionInCollection { get; set; }
    }
}