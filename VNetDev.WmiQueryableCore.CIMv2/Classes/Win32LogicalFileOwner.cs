using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_LogicalFileOwner
    /// </summary>
    [WmiClass(Name = "Win32_LogicalFileOwner")]
    public class Win32LogicalFileOwner
    {
        /// <summary>
        /// WMI Property Owner
        /// </summary>
        public object Owner { get; set; }

        /// <summary>
        /// WMI Property SecuritySetting
        /// </summary>
        public object SecuritySetting { get; set; }
    }
}