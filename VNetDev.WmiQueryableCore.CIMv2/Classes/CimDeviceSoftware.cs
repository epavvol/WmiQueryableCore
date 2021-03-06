using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_DeviceSoftware
    /// </summary>
    [WmiClass(Name = "CIM_DeviceSoftware")]
    public class CimDeviceSoftware
    {
        /// <summary>
        /// WMI Property Antecedent
        /// </summary>
        public object Antecedent { get; set; }

        /// <summary>
        /// WMI Property Dependent
        /// </summary>
        public object Dependent { get; set; }

        /// <summary>
        /// WMI Property Purpose
        /// </summary>
        public ushort Purpose { get; set; }

        /// <summary>
        /// WMI Property PurposeDescription
        /// </summary>
        public string PurposeDescription { get; set; }
    }
}