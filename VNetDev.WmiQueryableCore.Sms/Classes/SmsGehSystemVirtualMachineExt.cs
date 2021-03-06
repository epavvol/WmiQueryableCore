using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_VIRTUAL_MACHINE_EXT
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_VIRTUAL_MACHINE_EXT")]
    public class SmsGehSystemVirtualMachineExt
    {
        /// <summary>
        /// WMI Property CpuUtilization
        /// </summary>
        public uint CpuUtilization { get; set; }
        /// <summary>
        /// WMI Property DiskBytesRead
        /// </summary>
        public ulong DiskBytesRead { get; set; }
        /// <summary>
        /// WMI Property DiskBytesWritten
        /// </summary>
        public ulong DiskBytesWritten { get; set; }
        /// <summary>
        /// WMI Property DiskSpaceUsed
        /// </summary>
        public ulong DiskSpaceUsed { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property HeartbeatCount
        /// </summary>
        public ulong HeartbeatCount { get; set; }
        /// <summary>
        /// WMI Property HeartbeatInterval
        /// </summary>
        public uint HeartbeatInterval { get; set; }
        /// <summary>
        /// WMI Property HeartbeatPercentage
        /// </summary>
        public uint HeartbeatPercentage { get; set; }
        /// <summary>
        /// WMI Property HeartbeatRate
        /// </summary>
        public uint HeartbeatRate { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NetworkBytesReceived
        /// </summary>
        public ulong NetworkBytesReceived { get; set; }
        /// <summary>
        /// WMI Property NetworkBytesSent
        /// </summary>
        public ulong NetworkBytesSent { get; set; }
        /// <summary>
        /// WMI Property PhysicalMemoryAllocated
        /// </summary>
        public ulong PhysicalMemoryAllocated { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Uptime
        /// </summary>
        public uint Uptime { get; set; }
    }
}
