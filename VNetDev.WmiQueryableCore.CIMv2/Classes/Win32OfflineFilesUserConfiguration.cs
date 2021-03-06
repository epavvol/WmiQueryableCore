using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_OfflineFilesUserConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_OfflineFilesUserConfiguration")]
    public class Win32OfflineFilesUserConfiguration
    {
        /// <summary>
        /// WMI Property AssignedOfflineFiles
        /// </summary>
        public ICollection<string> AssignedOfflineFiles { get; set; }

        /// <summary>
        /// WMI Property IsConfiguredByWMI
        /// </summary>
        public bool IsConfiguredByWmi { get; set; }

        /// <summary>
        /// WMI Property MakeAvailableOfflineButtonRemoved
        /// </summary>
        public bool MakeAvailableOfflineButtonRemoved { get; set; }

        /// <summary>
        /// WMI Property WorkOfflineButtonRemoved
        /// </summary>
        public bool WorkOfflineButtonRemoved { get; set; }
    }
}