using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_LogicalShareAccess
    /// </summary>
    [WmiClass(Name = "Win32_LogicalShareAccess")]
    public class Win32LogicalShareAccess
    {
        /// <summary>
        /// WMI Property AccessMask
        /// </summary>
        public uint AccessMask { get; set; }

        /// <summary>
        /// WMI Property GuidInheritedObjectType
        /// </summary>
        public string GuidInheritedObjectType { get; set; }

        /// <summary>
        /// WMI Property GuidObjectType
        /// </summary>
        public string GuidObjectType { get; set; }

        /// <summary>
        /// WMI Property Inheritance
        /// </summary>
        public uint Inheritance { get; set; }

        /// <summary>
        /// WMI Property SecuritySetting
        /// </summary>
        public object SecuritySetting { get; set; }

        /// <summary>
        /// WMI Property Trustee
        /// </summary>
        public object Trustee { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}