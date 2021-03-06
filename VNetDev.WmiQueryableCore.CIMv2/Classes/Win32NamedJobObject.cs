using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NamedJobObject
    /// </summary>
    [WmiClass(Name = "Win32_NamedJobObject")]
    public class Win32NamedJobObject
    {
        /// <summary>
        /// WMI Property BasicUIRestrictions
        /// </summary>
        public uint BasicUiRestrictions { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
    }
}