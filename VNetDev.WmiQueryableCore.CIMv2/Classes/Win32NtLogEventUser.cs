using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NTLogEventUser
    /// </summary>
    [WmiClass(Name = "Win32_NTLogEventUser")]
    public class Win32NtLogEventUser
    {
        /// <summary>
        /// WMI Property Record
        /// </summary>
        public object Record { get; set; }

        /// <summary>
        /// WMI Property User
        /// </summary>
        public object User { get; set; }
    }
}