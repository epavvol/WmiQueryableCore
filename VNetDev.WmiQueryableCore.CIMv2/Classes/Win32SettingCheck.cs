using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SettingCheck
    /// </summary>
    [WmiClass(Name = "Win32_SettingCheck")]
    public class Win32SettingCheck
    {
        /// <summary>
        /// WMI Property Check
        /// </summary>
        public object Check { get; set; }

        /// <summary>
        /// WMI Property Setting
        /// </summary>
        public object Setting { get; set; }
    }
}