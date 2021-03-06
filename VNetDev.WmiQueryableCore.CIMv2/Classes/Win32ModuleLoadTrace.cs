using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ModuleLoadTrace
    /// </summary>
    [WmiClass(Name = "Win32_ModuleLoadTrace")]
    public class Win32ModuleLoadTrace
    {
        /// <summary>
        /// WMI Property DefaultBase
        /// </summary>
        public ulong DefaultBase { get; set; }

        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// WMI Property ImageBase
        /// </summary>
        public ulong ImageBase { get; set; }

        /// <summary>
        /// WMI Property ImageChecksum
        /// </summary>
        public uint ImageChecksum { get; set; }

        /// <summary>
        /// WMI Property ImageSize
        /// </summary>
        public ulong ImageSize { get; set; }

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
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }

        /// <summary>
        /// WMI Property TimeDateStamp
        /// </summary>
        public uint TimeDateStamp { get; set; }
    }
}