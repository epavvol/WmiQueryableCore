using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_MountPoint
    /// </summary>
    [WmiClass(Name = "Win32_MountPoint")]
    public class Win32MountPoint
    {
        /// <summary>
        /// WMI Property Directory
        /// </summary>
        public object Directory { get; set; }

        /// <summary>
        /// WMI Property Volume
        /// </summary>
        public object Volume { get; set; }
    }
}