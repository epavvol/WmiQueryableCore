using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_LogicalFileGroup
    /// </summary>
    [WmiClass(Name = "Win32_LogicalFileGroup")]
    public class Win32LogicalFileGroup
    {
        /// <summary>
        /// WMI Property Group
        /// </summary>
        public object Group { get; set; }

        /// <summary>
        /// WMI Property SecuritySetting
        /// </summary>
        public object SecuritySetting { get; set; }
    }
}