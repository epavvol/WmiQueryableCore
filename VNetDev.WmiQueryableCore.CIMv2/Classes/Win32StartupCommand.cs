using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_StartupCommand
    /// </summary>
    [WmiClass(Name = "Win32_StartupCommand")]
    public class Win32StartupCommand
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Command
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property User
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// WMI Property UserSID
        /// </summary>
        public string UserSid { get; set; }
    }
}