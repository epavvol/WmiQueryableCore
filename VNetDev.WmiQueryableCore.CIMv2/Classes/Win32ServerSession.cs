using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_ServerSession
    /// </summary>
    [WmiClass(Name = "Win32_ServerSession")]
    public class Win32ServerSession
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
        /// WMI Property ClientType
        /// </summary>
        public string ClientType { get; set; }

        /// <summary>
        /// WMI Property ComputerName
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property IdleTime
        /// </summary>
        public uint IdleTime { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property ResourcesOpened
        /// </summary>
        public uint ResourcesOpened { get; set; }

        /// <summary>
        /// WMI Property SessionType
        /// </summary>
        public uint SessionType { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property TransportName
        /// </summary>
        public string TransportName { get; set; }

        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}