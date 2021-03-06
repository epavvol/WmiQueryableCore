using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SecuritySettingOfLogicalFile
    /// </summary>
    [WmiClass(Name = "Win32_SecuritySettingOfLogicalFile")]
    public class Win32SecuritySettingOfLogicalFile
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Setting
        /// </summary>
        public object Setting { get; set; }
    }
}