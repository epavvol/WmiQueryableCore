using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesFileSysInfo
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesFileSysInfo")]
    public class Win32OfflineFilesFileSysInfo
    {
        /// <summary>
        /// WMI Property LocalAttributes
        /// </summary>
        public uint LocalAttributes { get; set; }

        /// <summary>
        /// WMI Property LocalChangeTime
        /// </summary>
        public DateTime LocalChangeTime { get; set; }

        /// <summary>
        /// WMI Property LocalCreationTime
        /// </summary>
        public DateTime LocalCreationTime { get; set; }

        /// <summary>
        /// WMI Property LocalLastAccessTime
        /// </summary>
        public DateTime LocalLastAccessTime { get; set; }

        /// <summary>
        /// WMI Property LocalLastWriteTime
        /// </summary>
        public DateTime LocalLastWriteTime { get; set; }

        /// <summary>
        /// WMI Property LocalSize
        /// </summary>
        public long LocalSize { get; set; }

        /// <summary>
        /// WMI Property OriginalAttributes
        /// </summary>
        public uint OriginalAttributes { get; set; }

        /// <summary>
        /// WMI Property OriginalChangeTime
        /// </summary>
        public DateTime OriginalChangeTime { get; set; }

        /// <summary>
        /// WMI Property OriginalCreationTime
        /// </summary>
        public DateTime OriginalCreationTime { get; set; }

        /// <summary>
        /// WMI Property OriginalLastAccessTime
        /// </summary>
        public DateTime OriginalLastAccessTime { get; set; }

        /// <summary>
        /// WMI Property OriginalLastWriteTime
        /// </summary>
        public DateTime OriginalLastWriteTime { get; set; }

        /// <summary>
        /// WMI Property OriginalSize
        /// </summary>
        public long OriginalSize { get; set; }

        /// <summary>
        /// WMI Property RemoteAttributes
        /// </summary>
        public uint RemoteAttributes { get; set; }

        /// <summary>
        /// WMI Property RemoteChangeTime
        /// </summary>
        public DateTime RemoteChangeTime { get; set; }

        /// <summary>
        /// WMI Property RemoteCreationTime
        /// </summary>
        public DateTime RemoteCreationTime { get; set; }

        /// <summary>
        /// WMI Property RemoteLastAccessTime
        /// </summary>
        public DateTime RemoteLastAccessTime { get; set; }

        /// <summary>
        /// WMI Property RemoteLastWriteTime
        /// </summary>
        public DateTime RemoteLastWriteTime { get; set; }

        /// <summary>
        /// WMI Property RemoteSize
        /// </summary>
        public long RemoteSize { get; set; }
    }
}