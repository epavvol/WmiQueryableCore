using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_QuotaSetting
    /// </summary>
    [WmiClass(Name = "Win32_QuotaSetting")]
    public class Win32QuotaSetting
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property DefaultLimit
        /// </summary>
        public long DefaultLimit { get; set; }

        /// <summary>
        /// WMI Property DefaultWarningLimit
        /// </summary>
        public long DefaultWarningLimit { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property ExceededNotification
        /// </summary>
        public bool ExceededNotification { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }

        /// <summary>
        /// WMI Property VolumePath
        /// </summary>
        public string VolumePath { get; set; }

        /// <summary>
        /// WMI Property WarningExceededNotification
        /// </summary>
        public bool WarningExceededNotification { get; set; }
    }
}