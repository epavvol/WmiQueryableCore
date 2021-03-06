using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectSecLimitSetting
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectSecLimitSetting")]
    public class Win32NamedJobObjectSecLimitSetting
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
        /// WMI Property PrivilegesToDelete
        /// </summary>
        public object PrivilegesToDelete { get; set; }

        /// <summary>
        /// WMI Property RestrictedSIDs
        /// </summary>
        public object RestrictedSiDs { get; set; }

        /// <summary>
        /// WMI Property SecurityLimitFlags
        /// </summary>
        public uint SecurityLimitFlags { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property SIDsToDisable
        /// </summary>
        public object SiDsToDisable { get; set; }
    }
}