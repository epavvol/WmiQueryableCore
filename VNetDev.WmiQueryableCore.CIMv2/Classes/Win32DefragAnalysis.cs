using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DefragAnalysis
    /// </summary>
    [WmiClass(Name = "Win32_DefragAnalysis")]
    public class Win32DefragAnalysis
    {
        /// <summary>
        /// WMI Property AverageFileSize
        /// </summary>
        public ulong AverageFileSize { get; set; }

        /// <summary>
        /// WMI Property AverageFragmentsPerFile
        /// </summary>
        public double AverageFragmentsPerFile { get; set; }

        /// <summary>
        /// WMI Property AverageFreeSpacePerExtent
        /// </summary>
        public ulong AverageFreeSpacePerExtent { get; set; }

        /// <summary>
        /// WMI Property ClusterSize
        /// </summary>
        public ulong ClusterSize { get; set; }

        /// <summary>
        /// WMI Property ExcessFolderFragments
        /// </summary>
        public ulong ExcessFolderFragments { get; set; }

        /// <summary>
        /// WMI Property FilePercentFragmentation
        /// </summary>
        public uint FilePercentFragmentation { get; set; }

        /// <summary>
        /// WMI Property FragmentedFolders
        /// </summary>
        public ulong FragmentedFolders { get; set; }

        /// <summary>
        /// WMI Property FreeSpace
        /// </summary>
        public ulong FreeSpace { get; set; }

        /// <summary>
        /// WMI Property FreeSpacePercent
        /// </summary>
        public uint FreeSpacePercent { get; set; }

        /// <summary>
        /// WMI Property FreeSpacePercentFragmentation
        /// </summary>
        public uint FreeSpacePercentFragmentation { get; set; }

        /// <summary>
        /// WMI Property LargestFreeSpaceExtent
        /// </summary>
        public ulong LargestFreeSpaceExtent { get; set; }

        /// <summary>
        /// WMI Property MFTPercentInUse
        /// </summary>
        public uint MftPercentInUse { get; set; }

        /// <summary>
        /// WMI Property MFTRecordCount
        /// </summary>
        public ulong MftRecordCount { get; set; }

        /// <summary>
        /// WMI Property PageFileSize
        /// </summary>
        public ulong PageFileSize { get; set; }

        /// <summary>
        /// WMI Property TotalExcessFragments
        /// </summary>
        public ulong TotalExcessFragments { get; set; }

        /// <summary>
        /// WMI Property TotalFiles
        /// </summary>
        public ulong TotalFiles { get; set; }

        /// <summary>
        /// WMI Property TotalFolders
        /// </summary>
        public ulong TotalFolders { get; set; }

        /// <summary>
        /// WMI Property TotalFragmentedFiles
        /// </summary>
        public ulong TotalFragmentedFiles { get; set; }

        /// <summary>
        /// WMI Property TotalFreeSpaceExtents
        /// </summary>
        public ulong TotalFreeSpaceExtents { get; set; }

        /// <summary>
        /// WMI Property TotalMFTFragments
        /// </summary>
        public ulong TotalMftFragments { get; set; }

        /// <summary>
        /// WMI Property TotalMFTSize
        /// </summary>
        public ulong TotalMftSize { get; set; }

        /// <summary>
        /// WMI Property TotalPageFileFragments
        /// </summary>
        public ulong TotalPageFileFragments { get; set; }

        /// <summary>
        /// WMI Property TotalPercentFragmentation
        /// </summary>
        public uint TotalPercentFragmentation { get; set; }

        /// <summary>
        /// WMI Property TotalUnmovableFiles
        /// </summary>
        public ulong TotalUnmovableFiles { get; set; }

        /// <summary>
        /// WMI Property UsedSpace
        /// </summary>
        public ulong UsedSpace { get; set; }

        /// <summary>
        /// WMI Property VolumeName
        /// </summary>
        public string VolumeName { get; set; }

        /// <summary>
        /// WMI Property VolumeSize
        /// </summary>
        public ulong VolumeSize { get; set; }
    }
}