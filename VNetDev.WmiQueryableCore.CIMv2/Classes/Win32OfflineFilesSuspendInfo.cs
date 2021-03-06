using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesSuspendInfo
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesSuspendInfo")]
    public class Win32OfflineFilesSuspendInfo
    {
        /// <summary>
        /// WMI Property Suspended
        /// </summary>
        public bool Suspended { get; set; }

        /// <summary>
        /// WMI Property SuspendedRoot
        /// </summary>
        public bool SuspendedRoot { get; set; }
    }
}