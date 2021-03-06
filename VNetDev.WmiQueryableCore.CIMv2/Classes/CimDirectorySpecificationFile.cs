using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_DirectorySpecificationFile
    /// </summary>
    [WmiClass(Name = "CIM_DirectorySpecificationFile")]
    public class CimDirectorySpecificationFile
    {
        /// <summary>
        /// WMI Property DirectorySpecification
        /// </summary>
        public object DirectorySpecification { get; set; }

        /// <summary>
        /// WMI Property FileSpecification
        /// </summary>
        public object FileSpecification { get; set; }
    }
}