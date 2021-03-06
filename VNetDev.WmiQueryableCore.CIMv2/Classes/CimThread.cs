using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_Thread
    /// </summary>
    [WmiClass(Name = "CIM_Thread")]
    public class CimThread
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

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
        /// WMI Property ElapsedTime
        /// </summary>
        public ulong ElapsedTime { get; set; }

        /// <summary>
        /// WMI Property ExecutionState
        /// </summary>
        public ushort ExecutionState { get; set; }

        /// <summary>
        /// WMI Property Handle
        /// </summary>
        public string Handle { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property KernelModeTime
        /// </summary>
        public ulong KernelModeTime { get; set; }

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
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }

        /// <summary>
        /// WMI Property PriorityBase
        /// </summary>
        public uint PriorityBase { get; set; }

        /// <summary>
        /// WMI Property ProcessCreationClassName
        /// </summary>
        public string ProcessCreationClassName { get; set; }

        /// <summary>
        /// WMI Property ProcessHandle
        /// </summary>
        public string ProcessHandle { get; set; }

        /// <summary>
        /// WMI Property StartAddress
        /// </summary>
        public uint StartAddress { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property ThreadState
        /// </summary>
        public uint ThreadState { get; set; }

        /// <summary>
        /// WMI Property ThreadWaitReason
        /// </summary>
        public uint ThreadWaitReason { get; set; }

        /// <summary>
        /// WMI Property UserModeTime
        /// </summary>
        public ulong UserModeTime { get; set; }
    }
}