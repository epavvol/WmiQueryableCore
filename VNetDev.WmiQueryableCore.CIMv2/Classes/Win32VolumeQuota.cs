using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_VolumeQuota
    /// </summary>
    [WmiClass(Name = "Win32_VolumeQuota")]
    public class Win32VolumeQuota
    {
        /// <summary>
        /// WMI Property Element
        /// </summary>
        public object Element { get; set; }

        /// <summary>
        /// WMI Property Setting
        /// </summary>
        public object Setting { get; set; }
    }
}