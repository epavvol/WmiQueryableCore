using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesDirtyInfo
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesDirtyInfo")]
    public class Win32OfflineFilesDirtyInfo
    {
        /// <summary>
        /// WMI Property LocalDirtyByteCount
        /// </summary>
        public long LocalDirtyByteCount { get; set; }

        /// <summary>
        /// WMI Property RemoteDirtyByteCount
        /// </summary>
        public long RemoteDirtyByteCount { get; set; }
    }
}