using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesConnectionInfo
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesConnectionInfo")]
    public class Win32OfflineFilesConnectionInfo
    {
        /// <summary>
        /// WMI Property ConnectState
        /// </summary>
        public uint ConnectState { get; set; }

        /// <summary>
        /// WMI Property OfflineReason
        /// </summary>
        public uint OfflineReason { get; set; }
    }
}