using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_WmiFilterDeactivated
    /// </summary>
    [WmiClass(Name = "MSFT_WmiFilterDeactivated")]
    public class MsftWmiFilterDeactivated
    {
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property Namespace
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// WMI Property Query
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// WMI Property QueryLanguage
        /// </summary>
        public string QueryLanguage { get; set; }

        /// <summary>
        /// WMI Property SECURITY_DESCRIPTOR
        /// </summary>
        [WmiProperty(Name = "SECURITY_DESCRIPTOR")]
        public ICollection<byte> MsftSecurityDescriptor { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong MsftTimeCreated { get; set; }
    }
}