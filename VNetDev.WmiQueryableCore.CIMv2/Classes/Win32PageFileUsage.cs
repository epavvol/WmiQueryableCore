using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_PageFileUsage
    /// </summary>
    [WmiClass(Name = "Win32_PageFileUsage")]
    public class Win32PageFileUsage
    {
        /// <summary>
        /// WMI Property AllocatedBaseSize
        /// </summary>
        public uint AllocatedBaseSize { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CurrentUsage
        /// </summary>
        public uint CurrentUsage { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PeakUsage
        /// </summary>
        public uint PeakUsage { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property TempPageFile
        /// </summary>
        public bool TempPageFile { get; set; }
    }
}