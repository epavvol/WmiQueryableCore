using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OSRecoveryConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_OSRecoveryConfiguration")]
    public class Win32OsRecoveryConfiguration
    {
        /// <summary>
        /// WMI Property AutoReboot
        /// </summary>
        public bool AutoReboot { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property DebugFilePath
        /// </summary>
        public string DebugFilePath { get; set; }

        /// <summary>
        /// WMI Property DebugInfoType
        /// </summary>
        public uint DebugInfoType { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property ExpandedDebugFilePath
        /// </summary>
        public string ExpandedDebugFilePath { get; set; }

        /// <summary>
        /// WMI Property ExpandedMiniDumpDirectory
        /// </summary>
        public string ExpandedMiniDumpDirectory { get; set; }

        /// <summary>
        /// WMI Property KernelDumpOnly
        /// </summary>
        public bool KernelDumpOnly { get; set; }

        /// <summary>
        /// WMI Property MiniDumpDirectory
        /// </summary>
        public string MiniDumpDirectory { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property OverwriteExistingDebugFile
        /// </summary>
        public bool OverwriteExistingDebugFile { get; set; }

        /// <summary>
        /// WMI Property SendAdminAlert
        /// </summary>
        public bool SendAdminAlert { get; set; }

        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }

        /// <summary>
        /// WMI Property WriteDebugInfo
        /// </summary>
        public bool WriteDebugInfo { get; set; }

        /// <summary>
        /// WMI Property WriteToSystemLog
        /// </summary>
        public bool WriteToSystemLog { get; set; }
    }
}