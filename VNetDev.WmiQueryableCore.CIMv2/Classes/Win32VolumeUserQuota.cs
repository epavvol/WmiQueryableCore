using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_VolumeUserQuota
    /// </summary>
    [WmiClass(Name = "Win32_VolumeUserQuota")]
    public class Win32VolumeUserQuota
    {
        /// <summary>
        /// WMI Property Account
        /// </summary>
        public object Account { get; set; }

        /// <summary>
        /// WMI Property DiskSpaceUsed
        /// </summary>
        public ulong DiskSpaceUsed { get; set; }

        /// <summary>
        /// WMI Property Limit
        /// </summary>
        public ulong Limit { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }

        /// <summary>
        /// WMI Property Volume
        /// </summary>
        public object Volume { get; set; }

        /// <summary>
        /// WMI Property WarningLimit
        /// </summary>
        public ulong WarningLimit { get; set; }
    }
}