using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_FromDirectorySpecification
    /// </summary>
    [WmiClass(Name = "CIM_FromDirectorySpecification")]
    public class CimFromDirectorySpecification
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