using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_NetworkAdapterSettings
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_NetworkAdapterSettings")]
    public class SmsTaskSequenceNetworkAdapterSettings
    {
        /// <summary>
        /// WMI Property DNSServerList
        /// </summary>
        public ICollection<string> DnsServerList { get; set; }
        /// <summary>
        /// WMI Property EnableDHCP
        /// </summary>
        public bool EnableDhcp { get; set; }
        /// <summary>
        /// WMI Property EnableDNSRegistration
        /// </summary>
        public bool EnableDnsRegistration { get; set; }
        /// <summary>
        /// WMI Property EnableFullDNSRegistration
        /// </summary>
        public bool EnableFullDnsRegistration { get; set; }
        /// <summary>
        /// WMI Property EnableIPProtocolFiltering
        /// </summary>
        public bool EnableIpProtocolFiltering { get; set; }
        /// <summary>
        /// WMI Property EnableLMHOSTS
        /// </summary>
        public bool EnableLmhosts { get; set; }
        /// <summary>
        /// WMI Property EnableTCPFiltering
        /// </summary>
        public bool EnableTcpFiltering { get; set; }
        /// <summary>
        /// WMI Property EnableUDPFiltering
        /// </summary>
        public bool EnableUdpFiltering { get; set; }
        /// <summary>
        /// WMI Property EnableWINS
        /// </summary>
        public bool EnableWins { get; set; }
        /// <summary>
        /// WMI Property GatewayCostMetric
        /// </summary>
        public uint GatewayCostMetric { get; set; }
        /// <summary>
        /// WMI Property Gateways
        /// </summary>
        public ICollection<string> Gateways { get; set; }
        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }
        /// <summary>
        /// WMI Property IPAddressList
        /// </summary>
        public ICollection<string> IpAddressList { get; set; }
        /// <summary>
        /// WMI Property IPProtocolFilterList
        /// </summary>
        public ICollection<string> IpProtocolFilterList { get; set; }
        /// <summary>
        /// WMI Property MACAddress
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property SubnetMask
        /// </summary>
        public ICollection<string> SubnetMask { get; set; }
        /// <summary>
        /// WMI Property TCPFilterPortList
        /// </summary>
        public ICollection<int> TcpFilterPortList { get; set; }
        /// <summary>
        /// WMI Property TcpipNetbiosOptions
        /// </summary>
        public uint TcpipNetbiosOptions { get; set; }
        /// <summary>
        /// WMI Property UDPFilterPortList
        /// </summary>
        public ICollection<int> UdpFilterPortList { get; set; }
        /// <summary>
        /// WMI Property WINSServerList
        /// </summary>
        public ICollection<string> WinsServerList { get; set; }
    }
}
