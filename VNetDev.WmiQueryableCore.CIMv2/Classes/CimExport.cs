using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Export
    /// </summary>
    [WmiClass(Name = "CIM_Export")]
    public class CimExport
    {
        /// <summary>
        /// WMI Property Directory
        /// </summary>
        public object Directory { get; set; }

        /// <summary>
        /// WMI Property ExportedDirectoryName
        /// </summary>
        public string ExportedDirectoryName { get; set; }

        /// <summary>
        /// WMI Property LocalFS
        /// </summary>
        public object LocalFs { get; set; }
    }
}