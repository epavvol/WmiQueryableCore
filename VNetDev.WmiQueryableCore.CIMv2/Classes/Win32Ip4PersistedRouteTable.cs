using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_IP4PersistedRouteTable
    /// </summary>
    [WmiClass(Name = "Win32_IP4PersistedRouteTable")]
    public class Win32Ip4PersistedRouteTable
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
        /// WMI Property Destination
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Mask
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// WMI Property Metric1
        /// </summary>
        public int Metric1 { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NextHop
        /// </summary>
        public string NextHop { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}