using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ProcessStartTrace
    /// </summary>
    [WmiClass(Name = "Win32_ProcessStartTrace")]
    public class Win32ProcessStartTrace
    {
        /// <summary>
        /// WMI Property ParentProcessID
        /// </summary>
        public uint ParentProcessId { get; set; }

        /// <summary>
        /// WMI Property ProcessID
        /// </summary>
        public uint ProcessId { get; set; }

        /// <summary>
        /// WMI Property ProcessName
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> SecurityDescriptor { get; set; }

        /// <summary>
        /// WMI Property SessionID
        /// </summary>
        public uint SessionId { get; set; }

        /// <summary>
        /// WMI Property Sid
        /// </summary>
        public ICollection<byte> Sid { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }
    }
}