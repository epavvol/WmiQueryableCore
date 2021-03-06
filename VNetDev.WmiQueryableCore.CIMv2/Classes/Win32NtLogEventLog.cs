using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NTLogEventLog
    /// </summary>
    [WmiClass(Name = "Win32_NTLogEventLog")]
    public class Win32NtLogEventLog
    {
        /// <summary>
        /// WMI Property Log
        /// </summary>
        public object Log { get; set; }

        /// <summary>
        /// WMI Property Record
        /// </summary>
        public object Record { get; set; }
    }
}