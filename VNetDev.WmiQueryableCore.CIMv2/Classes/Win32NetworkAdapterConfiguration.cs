using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NetworkAdapterConfiguration
    /// </summary>
    [WmiClass(Name = "Win32_NetworkAdapterConfiguration")]
    public class Win32NetworkAdapterConfiguration
    {
        /// <summary>
        /// WMI method <c>DisableIPSec</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint DisableIpSecDelegate();

        /// <summary>
        /// WMI method <c>EnableDHCP</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableDhcpDelegate();

        /// <summary>
        /// WMI static method <c>EnableDNS</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="dnsDomain">WMI Property <c>DNSDomain</c> of type <c>string</c>.</param>
        /// <param name="dnsDomainSuffixSearchOrder">WMI Property <c>DNSDomainSuffixSearchOrder</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="dnsHostName">WMI Property <c>DNSHostName</c> of type <c>string</c>.</param>
        /// <param name="dnsServerSearchOrder">WMI Property <c>DNSServerSearchOrder</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableDnsDelegate(WmiContext wmiContext, string dnsDomain = default,
            ICollection<string> dnsDomainSuffixSearchOrder = default, string dnsHostName = default,
            ICollection<string> dnsServerSearchOrder = default);

        /// <summary>
        /// WMI static method <c>EnableIPFilterSec</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="ipFilterSecurityEnabled">WMI Property <c>IPFilterSecurityEnabled</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableIpFilterSecDelegate(WmiContext wmiContext, bool ipFilterSecurityEnabled = default);

        /// <summary>
        /// WMI method <c>EnableIPSec</c> describing delegate.
        /// <param name="ipSecPermitIpProtocols">WMI Property <c>IPSecPermitIPProtocols</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="ipSecPermitTcpPorts">WMI Property <c>IPSecPermitTCPPorts</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="ipSecPermitUdpPorts">WMI Property <c>IPSecPermitUDPPorts</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableIpSecDelegate(ICollection<string> ipSecPermitIpProtocols = default,
            ICollection<string> ipSecPermitTcpPorts = default, ICollection<string> ipSecPermitUdpPorts = default);

        /// <summary>
        /// WMI method <c>EnableStatic</c> describing delegate.
        /// <param name="ipAddress">WMI Property <c>IPAddress</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="subnetMask">WMI Property <c>SubnetMask</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableStaticDelegate(ICollection<string> ipAddress = default,
            ICollection<string> subnetMask = default);

        /// <summary>
        /// WMI static method <c>EnableWINS</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="dnsEnabledForWinsResolution">WMI Property <c>DNSEnabledForWINSResolution</c> of type <c>bool</c>.</param>
        /// <param name="winsEnableLmHostsLookup">WMI Property <c>WINSEnableLMHostsLookup</c> of type <c>bool</c>.</param>
        /// <param name="winsHostLookupFile">WMI Property <c>WINSHostLookupFile</c> of type <c>string</c>.</param>
        /// <param name="winsScopeId">WMI Property <c>WINSScopeID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint EnableWinsDelegate(WmiContext wmiContext, bool dnsEnabledForWinsResolution = default,
            bool winsEnableLmHostsLookup = default, string winsHostLookupFile = default, string winsScopeId = default);

        /// <summary>
        /// WMI static method <c>ReleaseDHCPLeaseAll</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ReleaseDhcpLeaseAllDelegate(WmiContext wmiContext);

        /// <summary>
        /// WMI method <c>ReleaseDHCPLease</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ReleaseDhcpLeaseDelegate();

        /// <summary>
        /// WMI static method <c>RenewDHCPLeaseAll</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenewDhcpLeaseAllDelegate(WmiContext wmiContext);

        /// <summary>
        /// WMI method <c>RenewDHCPLease</c> describing delegate.
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RenewDhcpLeaseDelegate();

        /// <summary>
        /// WMI static method <c>SetArpAlwaysSourceRoute</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="arpAlwaysSourceRoute">WMI Property <c>ArpAlwaysSourceRoute</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint
            SetArpAlwaysSourceRouteDelegate(WmiContext wmiContext, bool arpAlwaysSourceRoute = default);

        /// <summary>
        /// WMI static method <c>SetArpUseEtherSNAP</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="arpUseEtherSnap">WMI Property <c>ArpUseEtherSNAP</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetArpUseEtherSnapDelegate(WmiContext wmiContext, bool arpUseEtherSnap = default);

        /// <summary>
        /// WMI static method <c>SetDatabasePath</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="databasePath">WMI Property <c>DatabasePath</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDatabasePathDelegate(WmiContext wmiContext, string databasePath = default);

        /// <summary>
        /// WMI static method <c>SetDeadGWDetect</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="deadGwDetectEnabled">WMI Property <c>DeadGWDetectEnabled</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDeadGwDetectDelegate(WmiContext wmiContext, bool deadGwDetectEnabled = default);

        /// <summary>
        /// WMI static method <c>SetDefaultTOS</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="defaultTos">WMI Property <c>DefaultTOS</c> of type <c>byte</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDefaultTosDelegate(WmiContext wmiContext, byte defaultTos = default);

        /// <summary>
        /// WMI static method <c>SetDefaultTTL</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="defaultTtl">WMI Property <c>DefaultTTL</c> of type <c>byte</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDefaultTtlDelegate(WmiContext wmiContext, byte defaultTtl = default);

        /// <summary>
        /// WMI method <c>SetDNSDomain</c> describing delegate.
        /// <param name="dnsDomain">WMI Property <c>DNSDomain</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDnsDomainDelegate(string dnsDomain = default);

        /// <summary>
        /// WMI method <c>SetDNSServerSearchOrder</c> describing delegate.
        /// <param name="dnsServerSearchOrder">WMI Property <c>DNSServerSearchOrder</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDnsServerSearchOrderDelegate(ICollection<string> dnsServerSearchOrder = default);

        /// <summary>
        /// WMI static method <c>SetDNSSuffixSearchOrder</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="dnsDomainSuffixSearchOrder">WMI Property <c>DNSDomainSuffixSearchOrder</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDnsSuffixSearchOrderDelegate(WmiContext wmiContext,
            ICollection<string> dnsDomainSuffixSearchOrder = default);

        /// <summary>
        /// WMI method <c>SetDynamicDNSRegistration</c> describing delegate.
        /// <param name="domainDnsRegistrationEnabled">WMI Property <c>DomainDNSRegistrationEnabled</c> of type <c>bool</c>.</param>
        /// <param name="fullDnsRegistrationEnabled">WMI Property <c>FullDNSRegistrationEnabled</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetDynamicDnsRegistrationDelegate(bool domainDnsRegistrationEnabled = default,
            bool fullDnsRegistrationEnabled = default);

        /// <summary>
        /// WMI static method <c>SetForwardBufferMemory</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="forwardBufferMemory">WMI Property <c>ForwardBufferMemory</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetForwardBufferMemoryDelegate(WmiContext wmiContext, uint forwardBufferMemory = default);

        /// <summary>
        /// WMI method <c>SetGateways</c> describing delegate.
        /// <param name="defaultIpGateway">WMI Property <c>DefaultIPGateway</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="gatewayCostMetric">WMI Property <c>GatewayCostMetric</c> of type <c>ICollection{ushort}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetGatewaysDelegate(ICollection<string> defaultIpGateway = default,
            ICollection<ushort> gatewayCostMetric = default);

        /// <summary>
        /// WMI static method <c>SetIGMPLevel</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="igmpLevel">WMI Property <c>IGMPLevel</c> of type <c>byte</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetIgmpLevelDelegate(WmiContext wmiContext, byte igmpLevel = default);

        /// <summary>
        /// WMI method <c>SetIPConnectionMetric</c> describing delegate.
        /// <param name="ipConnectionMetric">WMI Property <c>IPConnectionMetric</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetIpConnectionMetricDelegate(uint ipConnectionMetric = default);

        /// <summary>
        /// WMI static method <c>SetIPUseZeroBroadcast</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="ipUseZeroBroadcast">WMI Property <c>IPUseZeroBroadcast</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetIpUseZeroBroadcastDelegate(WmiContext wmiContext, bool ipUseZeroBroadcast = default);

        /// <summary>
        /// WMI method <c>SetIPXFrameTypeNetworkPairs</c> describing delegate.
        /// <param name="ipxFrameType">WMI Property <c>IPXFrameType</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="ipxNetworkNumber">WMI Property <c>IPXNetworkNumber</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetIpxFrameTypeNetworkPairsDelegate(ICollection<uint> ipxFrameType = default,
            ICollection<string> ipxNetworkNumber = default);

        /// <summary>
        /// WMI static method <c>SetIPXVirtualNetworkNumber</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="ipxVirtualNetNumber">WMI Property <c>IPXVirtualNetNumber</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetIpxVirtualNetworkNumberDelegate(WmiContext wmiContext,
            string ipxVirtualNetNumber = default);

        /// <summary>
        /// WMI static method <c>SetKeepAliveInterval</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="keepAliveInterval">WMI Property <c>KeepAliveInterval</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetKeepAliveIntervalDelegate(WmiContext wmiContext, uint keepAliveInterval = default);

        /// <summary>
        /// WMI static method <c>SetKeepAliveTime</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="keepAliveTime">WMI Property <c>KeepAliveTime</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetKeepAliveTimeDelegate(WmiContext wmiContext, uint keepAliveTime = default);

        /// <summary>
        /// WMI static method <c>SetMTU</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="mtu">WMI Property <c>MTU</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetMtuDelegate(WmiContext wmiContext, uint mtu = default);

        /// <summary>
        /// WMI static method <c>SetNumForwardPackets</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="numForwardPackets">WMI Property <c>NumForwardPackets</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetNumForwardPacketsDelegate(WmiContext wmiContext, uint numForwardPackets = default);

        /// <summary>
        /// WMI static method <c>SetPMTUBHDetect</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="pmtubhDetectEnabled">WMI Property <c>PMTUBHDetectEnabled</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPmtubhDetectDelegate(WmiContext wmiContext, bool pmtubhDetectEnabled = default);

        /// <summary>
        /// WMI static method <c>SetPMTUDiscovery</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="pmtuDiscoveryEnabled">WMI Property <c>PMTUDiscoveryEnabled</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetPmtuDiscoveryDelegate(WmiContext wmiContext, bool pmtuDiscoveryEnabled = default);

        /// <summary>
        /// WMI method <c>SetTcpipNetbios</c> describing delegate.
        /// <param name="tcpipNetbiosOptions">WMI Property <c>TcpipNetbiosOptions</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetTcpipNetbiosDelegate(uint tcpipNetbiosOptions = default);

        /// <summary>
        /// WMI static method <c>SetTcpMaxConnectRetransmissions</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tcpMaxConnectRetransmissions">WMI Property <c>TcpMaxConnectRetransmissions</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetTcpMaxConnectRetransmissionsDelegate(WmiContext wmiContext,
            uint tcpMaxConnectRetransmissions = default);

        /// <summary>
        /// WMI static method <c>SetTcpMaxDataRetransmissions</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tcpMaxDataRetransmissions">WMI Property <c>TcpMaxDataRetransmissions</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetTcpMaxDataRetransmissionsDelegate(WmiContext wmiContext,
            uint tcpMaxDataRetransmissions = default);

        /// <summary>
        /// WMI static method <c>SetTcpNumConnections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tcpNumConnections">WMI Property <c>TcpNumConnections</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetTcpNumConnectionsDelegate(WmiContext wmiContext, uint tcpNumConnections = default);

        /// <summary>
        /// WMI static method <c>SetTcpUseRFC1122UrgentPointer</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tcpUseRfc1122UrgentPointer">WMI Property <c>TcpUseRFC1122UrgentPointer</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetTcpUseRfc1122UrgentPointerDelegate(WmiContext wmiContext,
            bool tcpUseRfc1122UrgentPointer = default);

        /// <summary>
        /// WMI static method <c>SetTcpWindowSize</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tcpWindowSize">WMI Property <c>TcpWindowSize</c> of type <c>ushort</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetTcpWindowSizeDelegate(WmiContext wmiContext, ushort tcpWindowSize = default);

        /// <summary>
        /// WMI method <c>SetWINSServer</c> describing delegate.
        /// <param name="winsPrimaryServer">WMI Property <c>WINSPrimaryServer</c> of type <c>string</c>.</param>
        /// <param name="winsSecondaryServer">WMI Property <c>WINSSecondaryServer</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SetWinsServerDelegate(string winsPrimaryServer = default,
            string winsSecondaryServer = default);

        /// <summary>
        /// WMI static method <c>RenewDHCPLeaseAll</c>.
        /// </summary>
        public static RenewDhcpLeaseAllDelegate RenewDhcpLeaseAll;

        /// <summary>
        /// WMI static method <c>ReleaseDHCPLeaseAll</c>.
        /// </summary>
        public static ReleaseDhcpLeaseAllDelegate ReleaseDhcpLeaseAll;

        /// <summary>
        /// WMI static method <c>EnableDNS</c>.
        /// </summary>
        public static EnableDnsDelegate EnableDns;

        /// <summary>
        /// WMI static method <c>SetDNSSuffixSearchOrder</c>.
        /// </summary>
        public static SetDnsSuffixSearchOrderDelegate SetDnsSuffixSearchOrder;

        /// <summary>
        /// WMI static method <c>EnableWINS</c>.
        /// </summary>
        public static EnableWinsDelegate EnableWins;

        /// <summary>
        /// WMI static method <c>SetIPXVirtualNetworkNumber</c>.
        /// </summary>
        public static SetIpxVirtualNetworkNumberDelegate SetIpxVirtualNetworkNumber;

        /// <summary>
        /// WMI static method <c>SetDatabasePath</c>.
        /// </summary>
        public static SetDatabasePathDelegate SetDatabasePath;

        /// <summary>
        /// WMI static method <c>SetIPUseZeroBroadcast</c>.
        /// </summary>
        public static SetIpUseZeroBroadcastDelegate SetIpUseZeroBroadcast;

        /// <summary>
        /// WMI static method <c>SetArpAlwaysSourceRoute</c>.
        /// </summary>
        public static SetArpAlwaysSourceRouteDelegate SetArpAlwaysSourceRoute;

        /// <summary>
        /// WMI static method <c>SetArpUseEtherSNAP</c>.
        /// </summary>
        public static SetArpUseEtherSnapDelegate SetArpUseEtherSnap;

        /// <summary>
        /// WMI static method <c>SetDefaultTOS</c>.
        /// </summary>
        public static SetDefaultTosDelegate SetDefaultTos;

        /// <summary>
        /// WMI static method <c>SetDefaultTTL</c>.
        /// </summary>
        public static SetDefaultTtlDelegate SetDefaultTtl;

        /// <summary>
        /// WMI static method <c>SetDeadGWDetect</c>.
        /// </summary>
        public static SetDeadGwDetectDelegate SetDeadGwDetect;

        /// <summary>
        /// WMI static method <c>SetPMTUBHDetect</c>.
        /// </summary>
        public static SetPmtubhDetectDelegate SetPmtubhDetect;

        /// <summary>
        /// WMI static method <c>SetPMTUDiscovery</c>.
        /// </summary>
        public static SetPmtuDiscoveryDelegate SetPmtuDiscovery;

        /// <summary>
        /// WMI static method <c>SetForwardBufferMemory</c>.
        /// </summary>
        public static SetForwardBufferMemoryDelegate SetForwardBufferMemory;

        /// <summary>
        /// WMI static method <c>SetIGMPLevel</c>.
        /// </summary>
        public static SetIgmpLevelDelegate SetIgmpLevel;

        /// <summary>
        /// WMI static method <c>SetKeepAliveInterval</c>.
        /// </summary>
        public static SetKeepAliveIntervalDelegate SetKeepAliveInterval;

        /// <summary>
        /// WMI static method <c>SetKeepAliveTime</c>.
        /// </summary>
        public static SetKeepAliveTimeDelegate SetKeepAliveTime;

        /// <summary>
        /// WMI static method <c>SetMTU</c>.
        /// </summary>
        public static SetMtuDelegate SetMtu;

        /// <summary>
        /// WMI static method <c>SetNumForwardPackets</c>.
        /// </summary>
        public static SetNumForwardPacketsDelegate SetNumForwardPackets;

        /// <summary>
        /// WMI static method <c>SetTcpMaxConnectRetransmissions</c>.
        /// </summary>
        public static SetTcpMaxConnectRetransmissionsDelegate SetTcpMaxConnectRetransmissions;

        /// <summary>
        /// WMI static method <c>SetTcpMaxDataRetransmissions</c>.
        /// </summary>
        public static SetTcpMaxDataRetransmissionsDelegate SetTcpMaxDataRetransmissions;

        /// <summary>
        /// WMI static method <c>SetTcpNumConnections</c>.
        /// </summary>
        public static SetTcpNumConnectionsDelegate SetTcpNumConnections;

        /// <summary>
        /// WMI static method <c>SetTcpUseRFC1122UrgentPointer</c>.
        /// </summary>
        public static SetTcpUseRfc1122UrgentPointerDelegate SetTcpUseRfc1122UrgentPointer;

        /// <summary>
        /// WMI static method <c>SetTcpWindowSize</c>.
        /// </summary>
        public static SetTcpWindowSizeDelegate SetTcpWindowSize;

        /// <summary>
        /// WMI static method <c>EnableIPFilterSec</c>.
        /// </summary>
        public static EnableIpFilterSecDelegate EnableIpFilterSec;

        /// <summary>
        /// WMI method <c>DisableIPSec</c>.
        /// </summary>
        public DisableIpSecDelegate DisableIpSec;

        /// <summary>
        /// WMI method <c>EnableDHCP</c>.
        /// </summary>
        public EnableDhcpDelegate EnableDhcp;

        /// <summary>
        /// WMI method <c>EnableIPSec</c>.
        /// </summary>
        public EnableIpSecDelegate EnableIpSec;

        /// <summary>
        /// WMI method <c>EnableStatic</c>.
        /// </summary>
        public EnableStaticDelegate EnableStatic;

        /// <summary>
        /// WMI method <c>ReleaseDHCPLease</c>.
        /// </summary>
        public ReleaseDhcpLeaseDelegate ReleaseDhcpLease;

        /// <summary>
        /// WMI method <c>RenewDHCPLease</c>.
        /// </summary>
        public RenewDhcpLeaseDelegate RenewDhcpLease;

        /// <summary>
        /// WMI method <c>SetDNSDomain</c>.
        /// </summary>
        public SetDnsDomainDelegate SetDnsDomain;

        /// <summary>
        /// WMI method <c>SetDNSServerSearchOrder</c>.
        /// </summary>
        public SetDnsServerSearchOrderDelegate SetDnsServerSearchOrder;

        /// <summary>
        /// WMI method <c>SetDynamicDNSRegistration</c>.
        /// </summary>
        public SetDynamicDnsRegistrationDelegate SetDynamicDnsRegistration;

        /// <summary>
        /// WMI method <c>SetGateways</c>.
        /// </summary>
        public SetGatewaysDelegate SetGateways;

        /// <summary>
        /// WMI method <c>SetIPConnectionMetric</c>.
        /// </summary>
        public SetIpConnectionMetricDelegate SetIpConnectionMetric;

        /// <summary>
        /// WMI method <c>SetIPXFrameTypeNetworkPairs</c>.
        /// </summary>
        public SetIpxFrameTypeNetworkPairsDelegate SetIpxFrameTypeNetworkPairs;

        /// <summary>
        /// WMI method <c>SetTcpipNetbios</c>.
        /// </summary>
        public SetTcpipNetbiosDelegate SetTcpipNetbios;

        /// <summary>
        /// WMI method <c>SetWINSServer</c>.
        /// </summary>
        public SetWinsServerDelegate SetWinsServer;

        /// <summary>
        /// WMI Property ArpAlwaysSourceRoute
        /// </summary>
        public bool ArpAlwaysSourceRoute { get; set; }

        /// <summary>
        /// WMI Property ArpUseEtherSNAP
        /// </summary>
        public bool ArpUseEtherSnap { get; set; }

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
        public bool DeadGwDetectEnabled { get; set; }

        /// <summary>
        /// WMI Property DefaultIPGateway
        /// </summary>
        public ICollection<string> DefaultIpGateway { get; set; }

        /// <summary>
        /// WMI Property DefaultTOS
        /// </summary>
        public byte DefaultTos { get; set; }

        /// <summary>
        /// WMI Property DefaultTTL
        /// </summary>
        public byte DefaultTtl { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DHCPEnabled
        /// </summary>
        public bool DhcpEnabled { get; set; }

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
        public ICollection<string> DnsDomainSuffixSearchOrder { get; set; }

        /// <summary>
        /// WMI Property DNSEnabledForWINSResolution
        /// </summary>
        public bool DnsEnabledForWinsResolution { get; set; }

        /// <summary>
        /// WMI Property DNSHostName
        /// </summary>
        public string DnsHostName { get; set; }

        /// <summary>
        /// WMI Property DNSServerSearchOrder
        /// </summary>
        public ICollection<string> DnsServerSearchOrder { get; set; }

        /// <summary>
        /// WMI Property DomainDNSRegistrationEnabled
        /// </summary>
        public bool DomainDnsRegistrationEnabled { get; set; }

        /// <summary>
        /// WMI Property ForwardBufferMemory
        /// </summary>
        public uint ForwardBufferMemory { get; set; }

        /// <summary>
        /// WMI Property FullDNSRegistrationEnabled
        /// </summary>
        public bool FullDnsRegistrationEnabled { get; set; }

        /// <summary>
        /// WMI Property GatewayCostMetric
        /// </summary>
        public ICollection<ushort> GatewayCostMetric { get; set; }

        /// <summary>
        /// WMI Property IGMPLevel
        /// </summary>
        public byte IgmpLevel { get; set; }

        /// <summary>
        /// WMI Property Index
        /// </summary>
        public uint Index { get; set; }

        /// <summary>
        /// WMI Property InterfaceIndex
        /// </summary>
        public uint InterfaceIndex { get; set; }

        /// <summary>
        /// WMI Property IPAddress
        /// </summary>
        public ICollection<string> IpAddress { get; set; }

        /// <summary>
        /// WMI Property IPConnectionMetric
        /// </summary>
        public uint IpConnectionMetric { get; set; }

        /// <summary>
        /// WMI Property IPEnabled
        /// </summary>
        public bool IpEnabled { get; set; }

        /// <summary>
        /// WMI Property IPFilterSecurityEnabled
        /// </summary>
        public bool IpFilterSecurityEnabled { get; set; }

        /// <summary>
        /// WMI Property IPPortSecurityEnabled
        /// </summary>
        public bool IpPortSecurityEnabled { get; set; }

        /// <summary>
        /// WMI Property IPSecPermitIPProtocols
        /// </summary>
        public ICollection<string> IpSecPermitIpProtocols { get; set; }

        /// <summary>
        /// WMI Property IPSecPermitTCPPorts
        /// </summary>
        public ICollection<string> IpSecPermitTcpPorts { get; set; }

        /// <summary>
        /// WMI Property IPSecPermitUDPPorts
        /// </summary>
        public ICollection<string> IpSecPermitUdpPorts { get; set; }

        /// <summary>
        /// WMI Property IPSubnet
        /// </summary>
        public ICollection<string> IpSubnet { get; set; }

        /// <summary>
        /// WMI Property IPUseZeroBroadcast
        /// </summary>
        public bool IpUseZeroBroadcast { get; set; }

        /// <summary>
        /// WMI Property IPXAddress
        /// </summary>
        public string IpxAddress { get; set; }

        /// <summary>
        /// WMI Property IPXEnabled
        /// </summary>
        public bool IpxEnabled { get; set; }

        /// <summary>
        /// WMI Property IPXFrameType
        /// </summary>
        public ICollection<uint> IpxFrameType { get; set; }

        /// <summary>
        /// WMI Property IPXMediaType
        /// </summary>
        public uint IpxMediaType { get; set; }

        /// <summary>
        /// WMI Property IPXNetworkNumber
        /// </summary>
        public ICollection<string> IpxNetworkNumber { get; set; }

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
        public bool PmtubhDetectEnabled { get; set; }

        /// <summary>
        /// WMI Property PMTUDiscoveryEnabled
        /// </summary>
        public bool PmtuDiscoveryEnabled { get; set; }

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
        public bool TcpUseRfc1122UrgentPointer { get; set; }

        /// <summary>
        /// WMI Property TcpWindowSize
        /// </summary>
        public ushort TcpWindowSize { get; set; }

        /// <summary>
        /// WMI Property WINSEnableLMHostsLookup
        /// </summary>
        public bool WinsEnableLmHostsLookup { get; set; }

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