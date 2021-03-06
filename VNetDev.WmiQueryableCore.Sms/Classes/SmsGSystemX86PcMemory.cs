using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_X86_PC_MEMORY
    /// </summary>
    [WmiClass(Name = "SMS_G_System_X86_PC_MEMORY")]
    public class SmsGSystemX86PcMemory
    {
        /// <summary>
        /// WMI Property AvailableVirtualMemory
        /// </summary>
        public ulong AvailableVirtualMemory { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
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
        /// WMI Property TotalPageFileSpace
        /// </summary>
        public ulong TotalPageFileSpace { get; set; }
        /// <summary>
        /// WMI Property TotalPhysicalMemory
        /// </summary>
        public ulong TotalPhysicalMemory { get; set; }
        /// <summary>
        /// WMI Property TotalVirtualMemory
        /// </summary>
        public ulong TotalVirtualMemory { get; set; }
    }
}
