using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_FolderRedirectionHealthConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_FolderRedirectionHealthConfiguration")]
    public class Win32FolderRedirectionHealthConfiguration
    {
        /// <summary>
        /// WMI Property LastSyncDurationCautionInHours
        /// </summary>
        public uint LastSyncDurationCautionInHours { get; set; }

        /// <summary>
        /// WMI Property LastSyncDurationUnhealthyInHours
        /// </summary>
        public uint LastSyncDurationUnhealthyInHours { get; set; }
    }
}