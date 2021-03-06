using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ToDirectoryAction
    /// </summary>
    [WmiClass(Name = "CIM_ToDirectoryAction")]
    public class CimToDirectoryAction
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