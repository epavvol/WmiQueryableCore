using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_CIMLogicalDeviceCIMDataFile
    /// </summary>
    [WmiClass(Name = "Win32_CIMLogicalDeviceCIMDataFile")]
    public class Win32CimLogicalDeviceCimDataFile
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