using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_JobObjectStatus
    /// </summary>
    [WmiClass(Name = "Win32_JobObjectStatus")]
    public class Win32JobObjectStatus
    {
        /// <summary>
        /// WMI Property AdditionalDescription
        /// </summary>
        public string AdditionalDescription { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Operation
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// WMI Property ParameterInfo
        /// </summary>
        public string ParameterInfo { get; set; }

        /// <summary>
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// WMI Property StatusCode
        /// </summary>
        public uint StatusCode { get; set; }

        /// <summary>
        /// WMI Property Win32ErrorCode
        /// </summary>
        public uint Win32ErrorCode { get; set; }
    }
}