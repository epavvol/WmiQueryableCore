using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_DependencyContext
    /// </summary>
    [WmiClass(Name = "CIM_DependencyContext")]
    public class CimDependencyContext
    {
        /// <summary>
        /// WMI Property Context
        /// </summary>
        public object Context { get; set; }

        /// <summary>
        /// WMI Property Dependency
        /// </summary>
        public object Dependency { get; set; }
    }
}