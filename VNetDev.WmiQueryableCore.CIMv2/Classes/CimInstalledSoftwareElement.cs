using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_InstalledSoftwareElement
    /// </summary>
    [WmiClass(Name = "CIM_InstalledSoftwareElement")]
    public class CimInstalledSoftwareElement
    {
        /// <summary>
        /// WMI Property Software
        /// </summary>
        public object Software { get; set; }

        /// <summary>
        /// WMI Property System
        /// </summary>
        public object System { get; set; }
    }
}