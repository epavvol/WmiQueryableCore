using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_InstalledOS
    /// </summary>
    [WmiClass(Name = "CIM_InstalledOS")]
    public class CimInstalledOs
    {
        /// <summary>
        /// WMI Property GroupComponent
        /// </summary>
        public object GroupComponent { get; set; }

        /// <summary>
        /// WMI Property PartComponent
        /// </summary>
        public object PartComponent { get; set; }

        /// <summary>
        /// WMI Property PrimaryOS
        /// </summary>
        public bool PrimaryOs { get; set; }
    }
}