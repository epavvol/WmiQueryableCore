using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ServerConnection
    /// </summary>
    [WmiClass(Name = "Win32_ServerConnection")]
    public class Win32ServerConnection
    {
        /// <summary>
        /// WMI Property ActiveTime
        /// </summary>
        public uint ActiveTime { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ComputerName
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// WMI Property ConnectionID
        /// </summary>
        public uint ConnectionId { get; set; }

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
        /// WMI Property NumberOfFiles
        /// </summary>
        public uint NumberOfFiles { get; set; }

        /// <summary>
        /// WMI Property NumberOfUsers
        /// </summary>
        public uint NumberOfUsers { get; set; }

        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}