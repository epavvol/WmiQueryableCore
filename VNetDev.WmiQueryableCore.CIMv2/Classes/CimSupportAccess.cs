using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_SupportAccess
    /// </summary>
    [WmiClass(Name = "CIM_SupportAccess")]
    public class CimSupportAccess
    {
        /// <summary>
        /// WMI Property CommunicationInfo
        /// </summary>
        public string CommunicationInfo { get; set; }

        /// <summary>
        /// WMI Property CommunicationMode
        /// </summary>
        public ushort CommunicationMode { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property Locale
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// WMI Property SupportAccessId
        /// </summary>
        public string SupportAccessId { get; set; }
    }
}