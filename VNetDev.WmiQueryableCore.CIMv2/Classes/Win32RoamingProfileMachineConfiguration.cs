using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_RoamingProfileMachineConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_RoamingProfileMachineConfiguration")]
    public class Win32RoamingProfileMachineConfiguration
    {
        /// <summary>
        /// WMI Property AddAdminGroupToRUPEnabled
        /// </summary>
        public bool AddAdminGroupToRupEnabled { get; set; }

        /// <summary>
        /// WMI Property AllowCrossForestUserPolicy
        /// </summary>
        public bool AllowCrossForestUserPolicy { get; set; }

        /// <summary>
        /// WMI Property BackgroundUploadParams
        /// </summary>
        public Win32RoamingProfileBackgroundUploadParams BackgroundUploadParams { get; set; }

        /// <summary>
        /// WMI Property DeleteProfilesOlderDays
        /// </summary>
        public ushort DeleteProfilesOlderDays { get; set; }

        /// <summary>
        /// WMI Property DeleteRoamingCacheEnabled
        /// </summary>
        public bool DeleteRoamingCacheEnabled { get; set; }

        /// <summary>
        /// WMI Property DetectSlowLinkDisabled
        /// </summary>
        public bool DetectSlowLinkDisabled { get; set; }

        /// <summary>
        /// WMI Property ForceUnloadDisabled
        /// </summary>
        public bool ForceUnloadDisabled { get; set; }

        /// <summary>
        /// WMI Property IsConfiguredByWMI
        /// </summary>
        public bool IsConfiguredByWmi { get; set; }

        /// <summary>
        /// WMI Property MachineProfilePath
        /// </summary>
        public string MachineProfilePath { get; set; }

        /// <summary>
        /// WMI Property OnlyAllowLocalProfiles
        /// </summary>
        public bool OnlyAllowLocalProfiles { get; set; }

        /// <summary>
        /// WMI Property OwnerCheckDisabled
        /// </summary>
        public bool OwnerCheckDisabled { get; set; }

        /// <summary>
        /// WMI Property PrimaryComputerEnabled
        /// </summary>
        public bool PrimaryComputerEnabled { get; set; }

        /// <summary>
        /// WMI Property ProfileUploadDisabled
        /// </summary>
        public bool ProfileUploadDisabled { get; set; }

        /// <summary>
        /// WMI Property SlowLinkTimeOutParams
        /// </summary>
        public Win32RoamingProfileSlowLinkParams SlowLinkTimeOutParams { get; set; }

        /// <summary>
        /// WMI Property SlowLinkUIEnabled
        /// </summary>
        public bool SlowLinkUiEnabled { get; set; }

        /// <summary>
        /// WMI Property TempProfileLogonBlocked
        /// </summary>
        public bool TempProfileLogonBlocked { get; set; }

        /// <summary>
        /// WMI Property WaitForNetworkInSec
        /// </summary>
        public ushort WaitForNetworkInSec { get; set; }

        /// <summary>
        /// WMI Property WaitForRemoteProfile
        /// </summary>
        public bool WaitForRemoteProfile { get; set; }
    }
}