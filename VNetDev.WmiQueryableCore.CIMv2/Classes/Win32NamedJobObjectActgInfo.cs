using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObjectActgInfo
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObjectActgInfo")]
    public class Win32NamedJobObjectActgInfo
    {
        /// <summary>
        /// WMI Property ActiveProcesses
        /// </summary>
        public uint ActiveProcesses { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property OtherOperationCount
        /// </summary>
        public ulong OtherOperationCount { get; set; }

        /// <summary>
        /// WMI Property OtherTransferCount
        /// </summary>
        public ulong OtherTransferCount { get; set; }

        /// <summary>
        /// WMI Property PeakJobMemoryUsed
        /// </summary>
        public uint PeakJobMemoryUsed { get; set; }

        /// <summary>
        /// WMI Property PeakProcessMemoryUsed
        /// </summary>
        public uint PeakProcessMemoryUsed { get; set; }

        /// <summary>
        /// WMI Property ReadOperationCount
        /// </summary>
        public ulong ReadOperationCount { get; set; }

        /// <summary>
        /// WMI Property ReadTransferCount
        /// </summary>
        public ulong ReadTransferCount { get; set; }

        /// <summary>
        /// WMI Property ThisPeriodTotalKernelTime
        /// </summary>
        public ulong ThisPeriodTotalKernelTime { get; set; }

        /// <summary>
        /// WMI Property ThisPeriodTotalUserTime
        /// </summary>
        public ulong ThisPeriodTotalUserTime { get; set; }

        /// <summary>
        /// WMI Property TotalKernelTime
        /// </summary>
        public ulong TotalKernelTime { get; set; }

        /// <summary>
        /// WMI Property TotalPageFaultCount
        /// </summary>
        public uint TotalPageFaultCount { get; set; }

        /// <summary>
        /// WMI Property TotalProcesses
        /// </summary>
        public uint TotalProcesses { get; set; }

        /// <summary>
        /// WMI Property TotalTerminatedProcesses
        /// </summary>
        public uint TotalTerminatedProcesses { get; set; }

        /// <summary>
        /// WMI Property TotalUserTime
        /// </summary>
        public ulong TotalUserTime { get; set; }

        /// <summary>
        /// WMI Property WriteOperationCount
        /// </summary>
        public ulong WriteOperationCount { get; set; }

        /// <summary>
        /// WMI Property WriteTransferCount
        /// </summary>
        public ulong WriteTransferCount { get; set; }
    }
}