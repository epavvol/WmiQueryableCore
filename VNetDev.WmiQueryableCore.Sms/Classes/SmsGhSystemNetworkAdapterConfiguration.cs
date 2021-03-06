using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_NETWORK_ADAPTER_CONFIGURATION
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_NETWORK_ADAPTER_CONFIGURATION")]
    public class SmsGhSystemNetworkAdapterConfiguration
    {
        /// <summary>
        /// WMI Property ArpAlwaysSourceRoute
        /// </summary>
        public uint ArpAlwaysSourceRoute { get; set; }
        /// <summary>
        /// WMI Property ArpUseEtherSNAP
        /// </summary>
        public uint ArpUseEtherSnap { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property DatabasePath
        /// </summary>
        public string DatabasePath { get; set; }
        /// <summary>
        /// WMI Property DeadGWDetectEnabled
        /// </summary>
        public uint DeadGwDetectEnabled { get; set; }
        /// <summary>
        /// WMI Property DefaultIPGateway
        /// </summary>
        public string DefaultIpGateway { get; set; }
        /// <summary>
        /// WMI Property DefaultTOS
        /// </summary>
        public uint DefaultTos { get; set; }
        /// <summary>
        /// WMI Property DefaultTTL
        /// </summary>
        public uint DefaultTtl { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DHCPEnabled
        /// </summary>
        public uint DhcpEnabled { get; set; }
        /// <summary>
        /// WMI Property DHCPLeaseExpires
        /// </summary>
        public DateTime DhcpLeaseExpires { get; set; }
        /// <summary>
        /// WMI Property DHCPLeaseObtained
        /// </summary>
        public DateTime DhcpLeaseObtained { get; set; }
        /// <summary>
        /// WMI Property DHCPServer
        /// </summary>
        public string DhcpServer { get; set; }
        /// <summary>
        /// WMI Property DNSDomain
        /// </summary>
        public string DnsDomain { get; set; }
        /// <summary>
        /// WMI Property DNSDomainSuffixSearchOrder
        /// </summary>
        public string DnsDomainSuffixSearchOrder { get; set; }
        /// <summary>
        /// WMI Property DNSEnabledForWINSResolution
        /// </summary>
        public uint DnsEnabledForWinsResolution { get; set; }
        /// <summary>
        /// WMI Property DNSHostName
        /// </summary>
        public string DnsHostName { get; set; }
        /// <summary>
        /// WMI Property DNSServerSearchOrder
        /// </summary>
        public string DnsServerSearchOrder { get; set; }
        /// <summary>
        /// WMI Property DomainDNSRegistrationEnabled
        /// </summary>
        public uint DomainDnsRegistrationEnabled { get; set; }
        /// <summary>
        /// WMI Property ForwardBufferMemory
        /// </summary>
        public uint ForwardBufferMemory { get; set; }
        /// <summary>
        /// WMI Property FullDNSRegistrationEnabled
        /// </summary>
        public uint FullDnsRegistrationEnabled { get; set; }
        /// <summary>
        /// WMI Property GatewayCostMetric
        /// </summary>
        public string GatewayCostMetric { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IGMPLevel
        /// </summary>
        public uint IgmpLevel { get; set; }
        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }
        /// <summary>
        /// WMI Property IPAddress
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// WMI Property IPConnectionMetric
        /// </summary>
        public uint IpConnectionMetric { get; set; }
        /// <summary>
        /// WMI Property IPEnabled
        /// </summary>
        public uint IpEnabled { get; set; }
        /// <summary>
        /// WMI Property IPFilterSecurityEnabled
        /// </summary>
        public uint IpFilterSecurityEnabled { get; set; }
        /// <summary>
        /// WMI Property IPPortSecurityEnabled
        /// </summary>
        public uint IpPortSecurityEnabled { get; set; }
        /// <summary>
        /// WMI Property IPSecPermitIPProtocols
        /// </summary>
        public string IpSecPermitIpProtocols { get; set; }
        /// <summary>
        /// WMI Property IPSecPermitTCPPorts
        /// </summary>
        public string IpSecPermitTcpPorts { get; set; }
        /// <summary>
        /// WMI Property IPSecPermitUDPPorts
        /// </summary>
        public string IpSecPermitUdpPorts { get; set; }
        /// <summary>
        /// WMI Property IPSubnet
        /// </summary>
        public string IpSubnet { get; set; }
        /// <summary>
        /// WMI Property IPUseZeroBroadcast
        /// </summary>
        public uint IpUseZeroBroadcast { get; set; }
        /// <summary>
        /// WMI Property IPXAddress
        /// </summary>
        public string IpxAddress { get; set; }
        /// <summary>
        /// WMI Property IPXEnabled
        /// </summary>
        public uint IpxEnabled { get; set; }
        /// <summary>
        /// WMI Property IPXFrameType
        /// </summary>
        public string IpxFrameType { get; set; }
        /// <summary>
        /// WMI Property IPXMediaType
        /// </summary>
        public uint IpxMediaType { get; set; }
        /// <summary>
        /// WMI Property IPXNetworkNumber
        /// </summary>
        public string IpxNetworkNumber { get; set; }
        /// <summary>
        /// WMI Property IPXVirtualNetNumber
        /// </summary>
        public string IpxVirtualNetNumber { get; set; }
        /// <summary>
        /// WMI Property KeepAliveInterval
        /// </summary>
        public uint KeepAliveInterval { get; set; }
        /// <summary>
        /// WMI Property KeepAliveTime
        /// </summary>
        public uint KeepAliveTime { get; set; }
        /// <summary>
        /// WMI Property MACAddress
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// WMI Property MTU
        /// </summary>
        public uint Mtu { get; set; }
        /// <summary>
        /// WMI Property NumForwardPackets
        /// </summary>
        public uint NumForwardPackets { get; set; }
        /// <summary>
        /// WMI Property PMTUBHDetectEnabled
        /// </summary>
        public uint PmtubhDetectEnabled { get; set; }
        /// <summary>
        /// WMI Property PMTUDiscoveryEnabled
        /// </summary>
        public uint PmtuDiscoveryEnabled { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property ServiceName
        /// </summary>
        public string ServiceName { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property TcpipNetbiosOptions
        /// </summary>
        public uint TcpipNetbiosOptions { get; set; }
        /// <summary>
        /// WMI Property TcpMaxConnectRetransmissions
        /// </summary>
        public uint TcpMaxConnectRetransmissions { get; set; }
        /// <summary>
        /// WMI Property TcpMaxDataRetransmissions
        /// </summary>
        public uint TcpMaxDataRetransmissions { get; set; }
        /// <summary>
        /// WMI Property TcpNumConnections
        /// </summary>
        public uint TcpNumConnections { get; set; }
        /// <summary>
        /// WMI Property TcpUseRFC1122UrgentPointer
        /// </summary>
        public uint TcpUseRfc1122UrgentPointer { get; set; }
        /// <summary>
        /// WMI Property TcpWindowSize
        /// </summary>
        public uint TcpWindowSize { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property WINSEnableLMHostsLookup
        /// </summary>
        public uint WinsEnableLmHostsLookup { get; set; }
        /// <summary>
        /// WMI Property WINSHostLookupFile
        /// </summary>
        public string WinsHostLookupFile { get; set; }
        /// <summary>
        /// WMI Property WINSPrimaryServer
        /// </summary>
        public string WinsPrimaryServer { get; set; }
        /// <summary>
        /// WMI Property WINSScopeID
        /// </summary>
        public string WinsScopeId { get; set; }
        /// <summary>
        /// WMI Property WINSSecondaryServer
        /// </summary>
        public string WinsSecondaryServer { get; set; }
    }
}
