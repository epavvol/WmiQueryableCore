using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesDiskSpaceLimit
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesDiskSpaceLimit")]
    public class Win32OfflineFilesDiskSpaceLimit
    {
        /// <summary>
        /// WMI Property AutoCacheSizeInMB
        /// </summary>
        public uint AutoCacheSizeInMb { get; set; }

        /// <summary>
        /// WMI Property TotalSizeInMB
        /// </summary>
        public uint TotalSizeInMb { get; set; }
    }
}