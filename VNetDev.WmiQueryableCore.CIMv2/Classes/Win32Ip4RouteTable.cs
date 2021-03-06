using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_IP4RouteTable
    /// </summary>
    [WmiClass(Name = "Win32_IP4RouteTable")]
    public class Win32Ip4RouteTable
    {
        /// <summary>
        /// WMI Property Age
        /// </summary>
        public uint Age { get; set; }

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
        /// WMI Property Information
        /// </summary>
        public string Information { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property InterfaceIndex
        /// </summary>
        public int InterfaceIndex { get; set; }

        /// <summary>
        /// WMI Property Mask
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// WMI Property Metric1
        /// </summary>
        public int Metric1 { get; set; }

        /// <summary>
        /// WMI Property Metric2
        /// </summary>
        public int Metric2 { get; set; }

        /// <summary>
        /// WMI Property Metric3
        /// </summary>
        public int Metric3 { get; set; }

        /// <summary>
        /// WMI Property Metric4
        /// </summary>
        public int Metric4 { get; set; }

        /// <summary>
        /// WMI Property Metric5
        /// </summary>
        public int Metric5 { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NextHop
        /// </summary>
        public string NextHop { get; set; }

        /// <summary>
        /// WMI Property Protocol
        /// </summary>
        public uint Protocol { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}