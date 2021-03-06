using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_DfsTarget
    /// </summary>
    [WmiClass(Name = "Win32_DfsTarget")]
    public class Win32DfsTarget
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property LinkName
        /// </summary>
        public string LinkName { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }

        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}