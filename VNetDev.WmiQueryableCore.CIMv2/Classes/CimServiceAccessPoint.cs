using System;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: CIM_ServiceAccessPoint
    /// </summary>
    [WmiClass(Name = "CIM_ServiceAccessPoint")]
    public class CimServiceAccessPoint
    {
        /// <summary>
        /// WMI Property ByteCount
        /// </summary>
        public bool ByteCount { get; set; }

        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property HostAddress
        /// </summary>
        public string HostAddress { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property PortNumber
        /// </summary>
        public uint PortNumber { get; set; }

        /// <summary>
        /// WMI Property Protocol
        /// </summary>
        public uint Protocol { get; set; }

        /// <summary>
        /// WMI Property Queue
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// WMI Property SNMPCommunity
        /// </summary>
        public string SnmpCommunity { get; set; }

        /// <summary>
        /// WMI Property SNMPDevIndex
        /// </summary>
        public uint SnmpDevIndex { get; set; }

        /// <summary>
        /// WMI Property SNMPEnabled
        /// </summary>
        public bool SnmpEnabled { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// WMI Property SystemCreationClassName
        /// </summary>
        public string SystemCreationClassName { get; set; }

        /// <summary>
        /// WMI Property SystemName
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}