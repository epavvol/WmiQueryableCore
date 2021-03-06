using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_RoamingProfileUserConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_RoamingProfileUserConfiguration")]
    public class Win32RoamingProfileUserConfiguration
    {
        /// <summary>
        /// WMI Property DirectoriesToSyncAtLogonLogoff
        /// </summary>
        public ICollection<string> DirectoriesToSyncAtLogonLogoff { get; set; }

        /// <summary>
        /// WMI Property ExcludedProfileDirs
        /// </summary>
        public ICollection<string> ExcludedProfileDirs { get; set; }

        /// <summary>
        /// WMI Property IsConfiguredByWMI
        /// </summary>
        public bool IsConfiguredByWmi { get; set; }
    }
}