using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_Trustee
    /// </summary>
    [WmiClass(Name = "Win32_Trustee")]
    public class Win32Trustee
    {
        /// <summary>
        /// WMI Property Domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property SID
        /// </summary>
        public ICollection<byte> Sid { get; set; }

        /// <summary>
        /// WMI Property SidLength
        /// </summary>
        public uint SidLength { get; set; }

        /// <summary>
        /// WMI Property SIDString
        /// </summary>
        public string SidString { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }
    }
}