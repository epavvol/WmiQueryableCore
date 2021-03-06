using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ActionCheck
    /// </summary>
    [WmiClass(Name = "Win32_ActionCheck")]
    public class Win32ActionCheck
    {
        /// <summary>
        /// WMI Property Action
        /// </summary>
        public object Action { get; set; }

        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }
    }
}