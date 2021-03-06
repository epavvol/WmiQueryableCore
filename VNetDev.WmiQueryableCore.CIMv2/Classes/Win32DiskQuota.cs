using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DiskQuota
    /// </summary>
    [WmiClass(Name = "Win32_DiskQuota")]
    public class Win32DiskQuota
    {
        /// <summary>
        /// WMI Property DiskSpaceUsed
        /// </summary>
        public ulong DiskSpaceUsed { get; set; }

        /// <summary>
        /// WMI Property Limit
        /// </summary>
        public ulong Limit { get; set; }

        /// <summary>
        /// WMI Property QuotaVolume
        /// </summary>
        public object QuotaVolume { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }

        /// <summary>
        /// WMI Property User
        /// </summary>
        public object User { get; set; }

        /// <summary>
        /// WMI Property WarningLimit
        /// </summary>
        public ulong WarningLimit { get; set; }
    }
}