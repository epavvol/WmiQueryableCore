using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: MSFT_NetCallToFunctionFailedII
    /// </summary>
    [WmiClass(Name = "MSFT_NetCallToFunctionFailedII")]
    public class MsftNetCallToFunctionFailedIi
    {
        /// <summary>
        /// WMI Property Argument
        /// </summary>
        public string Argument { get; set; }

        /// <summary>
        /// WMI Property Error
        /// </summary>
        public uint Error { get; set; }

        /// <summary>
        /// WMI Property FunctionName
        /// </summary>
        public string FunctionName { get; set; }

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