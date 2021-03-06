using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ComClassAutoEmulator
    /// </summary>
    [WmiClass(Name = "Win32_ComClassAutoEmulator")]
    public class Win32ComClassAutoEmulator
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