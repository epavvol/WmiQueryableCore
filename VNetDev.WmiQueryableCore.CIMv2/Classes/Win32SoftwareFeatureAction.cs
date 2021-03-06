using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SoftwareFeatureAction
    /// </summary>
    [WmiClass(Name = "Win32_SoftwareFeatureAction")]
    public class Win32SoftwareFeatureAction
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public object Action { get; set; }

        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }
    }
}