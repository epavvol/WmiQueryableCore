using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SoftwareFeatureServiceImplementation
    /// </summary>
    [WmiClass(Name = "CIM_SoftwareFeatureServiceImplementation")]
    public class CimSoftwareFeatureServiceImplementation
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