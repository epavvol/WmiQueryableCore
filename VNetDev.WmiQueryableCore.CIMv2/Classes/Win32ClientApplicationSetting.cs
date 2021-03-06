using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ClientApplicationSetting
    /// </summary>
    [WmiClass(Name = "Win32_ClientApplicationSetting")]
    public class Win32ClientApplicationSetting
    {
        /// <summary>
        /// WMI Property Application
        /// </summary>
        public object Application { get; set; }

        /// <summary>
        /// WMI Property Client
        /// </summary>
        public object Client { get; set; }
    }
}