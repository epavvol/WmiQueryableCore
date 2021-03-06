using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_RoamingProfileSlowLinkParams
    /// </summary>
    [WmiClass(Name = "Win32_RoamingProfileSlowLinkParams")]
    public class Win32RoamingProfileSlowLinkParams
    {
        /// <summary>
        /// WMI Property ConnectionTransferRate
        /// </summary>
        public uint ConnectionTransferRate { get; set; }

        /// <summary>
        /// WMI Property TimeOut
        /// </summary>
        public ushort TimeOut { get; set; }
    }
}