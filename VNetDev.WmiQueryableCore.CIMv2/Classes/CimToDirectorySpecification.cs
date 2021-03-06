using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ToDirectorySpecification
    /// </summary>
    [WmiClass(Name = "CIM_ToDirectorySpecification")]
    public class CimToDirectorySpecification
    {
        /// <summary>
        /// WMI Property DestinationDirectory
        /// </summary>
        public object DestinationDirectory { get; set; }

        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public object FileName { get; set; }
    }
}