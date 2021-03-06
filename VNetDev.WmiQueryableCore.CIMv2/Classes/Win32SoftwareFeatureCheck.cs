using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SoftwareFeatureCheck
    /// </summary>
    [WmiClass(Name = "Win32_SoftwareFeatureCheck")]
    public class Win32SoftwareFeatureCheck
    {
        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }
    }
}