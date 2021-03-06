using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PageFileSetting
    /// </summary>
    [WmiClass(Name = "Win32_PageFileSetting")]
    public class Win32PageFileSetting
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InitialSize
        /// </summary>
        public uint InitialSize { get; set; }

        /// <summary>
        /// WMI Property MaximumSize
        /// </summary>
        public uint MaximumSize { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
    }
}