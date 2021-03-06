using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_RoamingProfileBackgroundUploadParams
    /// </summary>
    [WmiClass(Name = "Win32_RoamingProfileBackgroundUploadParams")]
    public class Win32RoamingProfileBackgroundUploadParams
    {
        /// <summary>
        /// WMI Property Interval
        /// </summary>
        public ushort Interval { get; set; }

        /// <summary>
        /// WMI Property SchedulingMethod
        /// </summary>
        public byte SchedulingMethod { get; set; }

        /// <summary>
        /// WMI Property Time
        /// </summary>
        public ushort Time { get; set; }
    }
}