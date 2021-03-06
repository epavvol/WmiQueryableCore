using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_FromDirectoryAction
    /// </summary>
    [WmiClass(Name = "CIM_FromDirectoryAction")]
    public class CimFromDirectoryAction
    {
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public object FileName { get; set; }

        /// <summary>
        /// WMI Property SourceDirectory
        /// </summary>
        public object SourceDirectory { get; set; }
    }
}