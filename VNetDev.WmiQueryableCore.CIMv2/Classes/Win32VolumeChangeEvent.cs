using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_VolumeChangeEvent
    /// </summary>
    [WmiClass(Name = "Win32_VolumeChangeEvent")]
    public class Win32VolumeChangeEvent
    {
        /// <summary>
        /// WMI Property DriveName
        /// </summary>
        public string DriveName { get; set; }

        /// <summary>
        /// WMI Property EventType
        /// </summary>
        public ushort EventType { get; set; }

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
    }
}