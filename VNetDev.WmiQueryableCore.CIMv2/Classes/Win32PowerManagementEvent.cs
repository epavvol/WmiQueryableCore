using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PowerManagementEvent
    /// </summary>
    [WmiClass(Name = "Win32_PowerManagementEvent")]
    public class Win32PowerManagementEvent
    {
        /// <summary>
        /// WMI Property EventType
        /// </summary>
        public ushort EventType { get; set; }

        /// <summary>
        /// WMI Property OEMEventCode
        /// </summary>
        public ushort OemEventCode { get; set; }

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