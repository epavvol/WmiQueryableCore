using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_PROCESS
    /// </summary>
    [WmiClass(Name = "SMS_G_System_PROCESS")]
    public class SmsGSystemProcess
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property ExecutablePath
        /// </summary>
        public string ExecutablePath { get; set; }
        /// <summary>
        /// WMI Property ExecutionState
        /// </summary>
        public uint ExecutionState { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Handle
        /// </summary>
        public string Handle { get; set; }
        /// <summary>
        /// WMI Property HandleCount
        /// </summary>
        public uint HandleCount { get; set; }
        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }
        /// <summary>
        /// WMI Property KernelModeTime
        /// </summary>
        public string KernelModeTime { get; set; }
        /// <summary>
        /// WMI Property MaximumWorkingSetSize
        /// </summary>
        public uint MaximumWorkingSetSize { get; set; }
        /// <summary>
        /// WMI Property MinimumWorkingSetSize
        /// </summary>
        public uint MinimumWorkingSetSize { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OSName
        /// </summary>
        public string OsName { get; set; }
        /// <summary>
        /// WMI Property OtherOperationCount
        /// </summary>
        public string OtherOperationCount { get; set; }
        /// <summary>
        /// WMI Property OtherTransferCount
        /// </summary>
        public string OtherTransferCount { get; set; }
        /// <summary>
        /// WMI Property PageFaults
        /// </summary>
        public uint PageFaults { get; set; }
        /// <summary>
        /// WMI Property PageFileUsage
        /// </summary>
        public uint PageFileUsage { get; set; }
        /// <summary>
        /// WMI Property ParentProcessId
        /// </summary>
        public uint ParentProcessId { get; set; }
        /// <summary>
        /// WMI Property PeakPageFileUsage
        /// </summary>
        public uint PeakPageFileUsage { get; set; }
        /// <summary>
        /// WMI Property PeakVirtualSize
        /// </summary>
        public ulong PeakVirtualSize { get; set; }
        /// <summary>
        /// WMI Property PeakWorkingSetSize
        /// </summary>
        public uint PeakWorkingSetSize { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property PrivatePageCount
        /// </summary>
        public string PrivatePageCount { get; set; }
        /// <summary>
        /// WMI Property ProcessId
        /// </summary>
        public uint ProcessId { get; set; }
        /// <summary>
        /// WMI Property QuotaNonPagedPoolUsage
        /// </summary>
        public uint QuotaNonPagedPoolUsage { get; set; }
        /// <summary>
        /// WMI Property QuotaPagedPoolUsage
        /// </summary>
        public uint QuotaPagedPoolUsage { get; set; }
        /// <summary>
        /// WMI Property QuotaPeakNonPagedPoolUsage
        /// </summary>
        public uint QuotaPeakNonPagedPoolUsage { get; set; }
        /// <summary>
        /// WMI Property QuotaPeakPagedPoolUsage
        /// </summary>
        public uint QuotaPeakPagedPoolUsage { get; set; }
        /// <summary>
        /// WMI Property ReadOperationCount
        /// </summary>
        public string ReadOperationCount { get; set; }
        /// <summary>
        /// WMI Property ReadTransferCount
        /// </summary>
        public string ReadTransferCount { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SessionId
        /// </summary>
        public uint SessionId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// WMI Property TerminationDate
        /// </summary>
        public DateTime TerminationDate { get; set; }
        /// <summary>
        /// WMI Property ThreadCount
        /// </summary>
        public uint ThreadCount { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UserModeTime
        /// </summary>
        public ulong UserModeTime { get; set; }
        /// <summary>
        /// WMI Property VirtualSize
        /// </summary>
        public ulong VirtualSize { get; set; }
        /// <summary>
        /// WMI Property WindowsVersion
        /// </summary>
        public string WindowsVersion { get; set; }
        /// <summary>
        /// WMI Property WorkingSetSize
        /// </summary>
        public ulong WorkingSetSize { get; set; }
        /// <summary>
        /// WMI Property WriteOperationCount
        /// </summary>
        public string WriteOperationCount { get; set; }
        /// <summary>
        /// WMI Property WriteTransferCount
        /// </summary>
        public string WriteTransferCount { get; set; }
    }
}
