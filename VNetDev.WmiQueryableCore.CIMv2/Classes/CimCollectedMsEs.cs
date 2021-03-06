using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_CollectedMSEs
    /// </summary>
    [WmiClass(Name = "CIM_CollectedMSEs")]
    public class CimCollectedMsEs
    {
        /// <summary>
        /// WMI Property Collection
        /// </summary>
        public object Collection { get; set; }

        /// <summary>
        /// WMI Property Member
        /// </summary>
        public object Member { get; set; }
    }
}