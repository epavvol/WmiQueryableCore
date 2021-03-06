using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NTLogEventComputer
    /// </summary>
    [WmiClass(Name = "Win32_NTLogEventComputer")]
    public class Win32NtLogEventComputer
    {
        /// <summary>
        /// WMI Property Computer
        /// </summary>
        public object Computer { get; set; }

        /// <summary>
        /// WMI Property Record
        /// </summary>
        public object Record { get; set; }
    }
}