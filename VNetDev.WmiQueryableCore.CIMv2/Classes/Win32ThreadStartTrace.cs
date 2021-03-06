using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ThreadStartTrace
    /// </summary>
    [WmiClass(Name = "Win32_ThreadStartTrace")]
    public class Win32ThreadStartTrace
    {
        /// <summary>
        /// WMI Property ProcessID
        /// </summary>
        public uint ProcessId { get; set; }

        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> SecurityDescriptor { get; set; }

        /// <summary>
        /// WMI Property StackBase
        /// </summary>
        public ulong StackBase { get; set; }

        /// <summary>
        /// WMI Property StackLimit
        /// </summary>
        public ulong StackLimit { get; set; }

        /// <summary>
        /// WMI Property StartAddr
        /// </summary>
        public ulong StartAddr { get; set; }

        /// <summary>
        /// WMI Property ThreadID
        /// </summary>
        public uint ThreadId { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }

        /// <summary>
        /// WMI Property UserStackBase
        /// </summary>
        public ulong UserStackBase { get; set; }

        /// <summary>
        /// WMI Property UserStackLimit
        /// </summary>
        public ulong UserStackLimit { get; set; }

        /// <summary>
        /// WMI Property WaitMode
        /// </summary>
        public uint WaitMode { get; set; }

        /// <summary>
        /// WMI Property Win32StartAddr
        /// </summary>
        public ulong Win32StartAddr { get; set; }
    }
}