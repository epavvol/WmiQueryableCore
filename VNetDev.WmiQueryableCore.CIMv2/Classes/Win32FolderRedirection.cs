using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_FolderRedirection
    /// </summary>
    [WmiClass(Name = "Win32_FolderRedirection")]
    public class Win32FolderRedirection
    {
        /// <summary>
        /// WMI Property ContentsMoved
        /// </summary>
        public bool ContentsMoved { get; set; }

        /// <summary>
        /// WMI Property ContentsMovedOnPolicyRemoval
        /// </summary>
        public bool ContentsMovedOnPolicyRemoval { get; set; }

        /// <summary>
        /// WMI Property ContentsRenamedInLocalCache
        /// </summary>
        public bool ContentsRenamedInLocalCache { get; set; }

        /// <summary>
        /// WMI Property ExclusiveRightsGranted
        /// </summary>
        public bool ExclusiveRightsGranted { get; set; }

        /// <summary>
        /// WMI Property FolderId
        /// </summary>
        public string FolderId { get; set; }

        /// <summary>
        /// WMI Property MakeFolderAvailableOfflineDisabled
        /// </summary>
        public bool MakeFolderAvailableOfflineDisabled { get; set; }

        /// <summary>
        /// WMI Property RedirectionPath
        /// </summary>
        public string RedirectionPath { get; set; }

        /// <summary>
        /// WMI Property RedirectionType
        /// </summary>
        public byte RedirectionType { get; set; }
    }
}