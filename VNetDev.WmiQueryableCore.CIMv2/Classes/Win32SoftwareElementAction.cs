using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SoftwareElementAction
    /// </summary>
    [WmiClass(Name = "Win32_SoftwareElementAction")]
    public class Win32SoftwareElementAction
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