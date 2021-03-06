using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ACE
    /// </summary>
    [WmiClass(Name = "Win32_ACE")]
    public class Win32Ace
    {
        /// <summary>
        /// WMI Property AccessMask
        /// </summary>
        public uint AccessMask { get; set; }

        /// <summary>
        /// WMI Property AceFlags
        /// </summary>
        public uint AceFlags { get; set; }

        /// <summary>
        /// WMI Property AceType
        /// </summary>
        public uint AceType { get; set; }

        /// <summary>
        /// WMI Property GuidInheritedObjectType
        /// </summary>
        public string GuidInheritedObjectType { get; set; }

        /// <summary>
        /// WMI Property GuidObjectType
        /// </summary>
        public string GuidObjectType { get; set; }

        /// <summary>
        /// WMI Property TIME_CREATED
        /// </summary>
        [WmiProperty(Name = "TIME_CREATED")]
        public ulong TimeCreated { get; set; }

        /// <summary>
        /// WMI Property Trustee
        /// </summary>
        public object Trustee { get; set; }
    }
}