using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Process
    /// </summary>
    [WmiClass(Name = "Win32_Process")]
    public class Win32Process
    {
        /// <summary>
        /// WMI method <c>AttachDebugger</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AttachDebuggerDelegate();

        /// <summary>
        /// WMI static method <c>Create</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="commandLine">WMI Property <c>CommandLine</c> of type <c>string</c>.</param>
        /// <param name="currentDirectory">WMI Property <c>CurrentDirectory</c> of type <c>string</c>.</param>
        /// <param name="processStartupInformation">WMI Property <c>ProcessStartupInformation</c> of type <c> Win32ProcessStartup</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint CreateDelegate(WmiContext wmiContext, string commandLine = default,
            string currentDirectory = default, Win32ProcessStartup processStartupInformation = default);

        /// <summary>
        /// WMI method <c>GetAvailableVirtualSize</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetAvailableVirtualSizeDelegate();

        /// <summary>
        /// WMI method <c>GetOwner</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetOwnerDelegate();

        /// <summary>
        /// WMI method <c>GetOwnerSid</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetOwnerSidDelegate();

        /// <summary>
        /// WMI method <c>SetPriority</c> describing delegate.
        /// <param name="priority">WMI Property <c>Priority</c> of type <c>int</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPriorityDelegate(int priority = default);

        /// <summary>
        /// WMI method <c>Terminate</c> describing delegate.
        /// <param name="reason">WMI Property <c>Reason</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint TerminateDelegate(uint reason = default);

        /// <summary>
        /// WMI static method <c>Create</c>.
        /// </summary>
        public static CreateDelegate Create;

        /// <summary>
        /// WMI method <c>AttachDebugger</c>.
        /// </summary>
        public AttachDebuggerDelegate AttachDebugger;

        /// <summary>
        /// WMI method <c>GetAvailableVirtualSize</c>.
        /// </summary>
        public GetAvailableVirtualSizeDelegate GetAvailableVirtualSize;

        /// <summary>
        /// WMI method <c>GetOwner</c>.
        /// </summary>
        public GetOwnerDelegate GetOwner;

        /// <summary>
        /// WMI method <c>GetOwnerSid</c>.
        /// </summary>
        public GetOwnerSidDelegate GetOwnerSid;

        /// <summary>
        /// WMI method <c>SetPriority</c>.
        /// </summary>
        public SetPriorityDelegate SetPriority;

        /// <summary>
        /// WMI method <c>Terminate</c>.
        /// </summary>
        public TerminateDelegate Terminate;

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CommandLine
        /// </summary>
        public string CommandLine { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// WMI Property CSCreationClassName
        /// </summary>
        public string CsCreationClassName { get; set; }

        /// <summary>
        /// WMI Property CSName
        /// </summary>
        public string CsName { get; set; }

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
        public ushort ExecutionState { get; set; }

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
        public ulong KernelModeTime { get; set; }

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
        /// WMI Property OSCreationClassName
        /// </summary>
        public string OsCreationClassName { get; set; }

        /// <summary>
        /// WMI Property OSName
        /// </summary>
        public string OsName { get; set; }

        /// <summary>
        /// WMI Property OtherOperationCount
        /// </summary>
        public ulong OtherOperationCount { get; set; }

        /// <summary>
        /// WMI Property OtherTransferCount
        /// </summary>
        public ulong OtherTransferCount { get; set; }

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
        public ulong PrivatePageCount { get; set; }

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
        public ulong ReadOperationCount { get; set; }

        /// <summary>
        /// WMI Property ReadTransferCount
        /// </summary>
        public ulong ReadTransferCount { get; set; }

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
        public ulong WriteOperationCount { get; set; }

        /// <summary>
        /// WMI Property WriteTransferCount
        /// </summary>
        public ulong WriteTransferCount { get; set; }
    }
}