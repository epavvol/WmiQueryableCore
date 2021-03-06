using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesPinInfo
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesPinInfo")]
    public class Win32OfflineFilesPinInfo
    {
        /// <summary>
        /// WMI Property Pinned
        /// </summary>
        public bool Pinned { get; set; }

        /// <summary>
        /// WMI Property PinnedForComputer
        /// </summary>
        public uint PinnedForComputer { get; set; }

        /// <summary>
        /// WMI Property PinnedForFolderRedirection
        /// </summary>
        public uint PinnedForFolderRedirection { get; set; }

        /// <summary>
        /// WMI Property PinnedForUser
        /// </summary>
        public uint PinnedForUser { get; set; }

        /// <summary>
        /// WMI Property PinnedForUserByPolicy
        /// </summary>
        public uint PinnedForUserByPolicy { get; set; }
    }
}