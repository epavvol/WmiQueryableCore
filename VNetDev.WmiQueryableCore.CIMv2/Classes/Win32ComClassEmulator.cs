using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ComClassEmulator
    /// </summary>
    [WmiClass(Name = "Win32_ComClassEmulator")]
    public class Win32ComClassEmulator
    {
        /// <summary>
        /// WMI Property NewVersion
        /// </summary>
        public object NewVersion { get; set; }

        /// <summary>
        /// WMI Property OldVersion
        /// </summary>
        public object OldVersion { get; set; }
    }
}