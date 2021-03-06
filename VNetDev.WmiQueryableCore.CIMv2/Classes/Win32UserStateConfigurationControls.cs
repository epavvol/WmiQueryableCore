using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_UserStateConfigurationControls
    /// </summary>
    [WmiClass(Name = "Win32_UserStateConfigurationControls")]
    public class Win32UserStateConfigurationControls
    {
        /// <summary>
        /// WMI Property FolderRedirection
        /// </summary>
        public byte FolderRedirection { get; set; }

        /// <summary>
        /// WMI Property OfflineFiles
        /// </summary>
        public byte OfflineFiles { get; set; }

        /// <summary>
        /// WMI Property RoamingUserProfile
        /// </summary>
        public byte RoamingUserProfile { get; set; }
    }
}