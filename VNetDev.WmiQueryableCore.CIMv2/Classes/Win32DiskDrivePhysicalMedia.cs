using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DiskDrivePhysicalMedia
    /// </summary>
    [WmiClass(Name = "Win32_DiskDrivePhysicalMedia")]
    public class Win32DiskDrivePhysicalMedia
    {
        /// <summary>
        /// WMI Property Antecedent
        /// </summary>
        public object Antecedent { get; set; }

        /// <summary>
        /// WMI Property Dependent
        /// </summary>
        public object Dependent { get; set; }
    }
}