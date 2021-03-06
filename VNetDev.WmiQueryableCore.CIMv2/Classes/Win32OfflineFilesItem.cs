using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesItem
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesItem")]
    public class Win32OfflineFilesItem
    {
        /// <summary>
        /// WMI Property ChangeInfo
        /// </summary>
        public object ChangeInfo { get; set; }

        /// <summary>
        /// WMI Property ConnectionInfo
        /// </summary>
        public object ConnectionInfo { get; set; }

        /// <summary>
        /// WMI Property DirtyInfo
        /// </summary>
        public object DirtyInfo { get; set; }

        /// <summary>
        /// WMI Property Encrypted
        /// </summary>
        public bool Encrypted { get; set; }

        /// <summary>
        /// WMI Property FileSysInfo
        /// </summary>
        public object FileSysInfo { get; set; }

        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// WMI Property ItemPath
        /// </summary>
        public string ItemPath { get; set; }

        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public uint ItemType { get; set; }

        /// <summary>
        /// WMI Property ParentItemPath
        /// </summary>
        public string ParentItemPath { get; set; }

        /// <summary>
        /// WMI Property PinInfo
        /// </summary>
        public object PinInfo { get; set; }

        /// <summary>
        /// WMI Property Sparse
        /// </summary>
        public bool Sparse { get; set; }

        /// <summary>
        /// WMI Property SuspendInfo
        /// </summary>
        public object SuspendInfo { get; set; }
    }
}