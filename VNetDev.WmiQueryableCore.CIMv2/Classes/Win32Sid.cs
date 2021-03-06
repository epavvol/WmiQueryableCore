using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_SID
    /// </summary>
    [WmiClass(Name = "Win32_SID")]
    public class Win32Sid
    {
        /// <summary>
        /// WMI Property AccountName
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// WMI Property BinaryRepresentation
        /// </summary>
        public ICollection<byte> BinaryRepresentation { get; set; }

        /// <summary>
        /// WMI Property ReferencedDomainName
        /// </summary>
        public string ReferencedDomainName { get; set; }

        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// WMI Property SidLength
        /// </summary>
        public uint SidLength { get; set; }
    }
}