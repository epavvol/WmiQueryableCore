using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Resource
    /// </summary>
    [WmiClass(Name = "SMS_Resource")]
    public class SmsResource
    {
        /// <summary>
        /// WMI Property AADDeviceID
        /// </summary>
        public string AadDeviceId { get; set; }
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property Active
        /// </summary>
        public uint Active { get; set; }
        /// <summary>
        /// WMI Property ADSiteName
        /// </summary>
        public string AdSiteName { get; set; }
        /// <summary>
        /// WMI Property AgentName
        /// </summary>
        public ICollection<string> AgentName { get; set; }
        /// <summary>
        /// WMI Property AgentSite
        /// </summary>
        public ICollection<string> AgentSite { get; set; }
        /// <summary>
        /// WMI Property AgentTime
        /// </summary>
        public ICollection<DateTime> AgentTime { get; set; }
        /// <summary>
        /// WMI Property AlwaysInternet
        /// </summary>
        public uint AlwaysInternet { get; set; }
        /// <summary>
        /// WMI Property AMTFullVersion
        /// </summary>
        public string AmtFullVersion { get; set; }
        /// <summary>
        /// WMI Property AMTStatus
        /// </summary>
        public uint AmtStatus { get; set; }
        /// <summary>
        /// WMI Property Build
        /// </summary>
        public string Build { get; set; }
        /// <summary>
        /// WMI Property BuildExt
        /// </summary>
        public string BuildExt { get; set; }
        /// <summary>
        /// WMI Property Client
        /// </summary>
        public uint Client { get; set; }
        /// <summary>
        /// WMI Property ClientEdition
        /// </summary>
        public uint ClientEdition { get; set; }
        /// <summary>
        /// WMI Property ClientType
        /// </summary>
        public uint ClientType { get; set; }
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property CPUType
        /// </summary>
        public string CpuType { get; set; }
        /// <summary>
        /// WMI Property CreationDate
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// WMI Property Decommissioned
        /// </summary>
        public uint Decommissioned { get; set; }
        /// <summary>
        /// WMI Property DeviceOwner
        /// </summary>
        public uint DeviceOwner { get; set; }
        /// <summary>
        /// WMI Property DisableWindowsUpdateAccess
        /// </summary>
        public bool DisableWindowsUpdateAccess { get; set; }
        /// <summary>
        /// WMI Property DistinguishedName
        /// </summary>
        public string DistinguishedName { get; set; }
        /// <summary>
        /// WMI Property DNSForestGuid
        /// </summary>
        public string DnsForestGuid { get; set; }
        /// <summary>
        /// WMI Property DoNotConnectToWULocations
        /// </summary>
        public bool DoNotConnectToWuLocations { get; set; }
        /// <summary>
        /// WMI Property EASDeviceID
        /// </summary>
        public string EasDeviceId { get; set; }
        /// <summary>
        /// WMI Property ESUValue
        /// </summary>
        public string EsuValue { get; set; }
        /// <summary>
        /// WMI Property FullDomainName
        /// </summary>
        public string FullDomainName { get; set; }
        /// <summary>
        /// WMI Property HardwareID
        /// </summary>
        public string HardwareId { get; set; }
        /// <summary>
        /// WMI Property InternetEnabled
        /// </summary>
        public uint InternetEnabled { get; set; }
        /// <summary>
        /// WMI Property IPAddresses
        /// </summary>
        public ICollection<string> IpAddresses { get; set; }
        /// <summary>
        /// WMI Property IPSubnets
        /// </summary>
        public ICollection<string> IpSubnets { get; set; }
        /// <summary>
        /// WMI Property IPv6Addresses
        /// </summary>
        public ICollection<string> IPv6Addresses { get; set; }
        /// <summary>
        /// WMI Property IPv6Prefixes
        /// </summary>
        public ICollection<string> IPv6Prefixes { get; set; }
        /// <summary>
        /// WMI Property IsAOACCapable
        /// </summary>
        public bool IsAoacCapable { get; set; }
        /// <summary>
        /// WMI Property IsAssignedToUser
        /// </summary>
        public bool IsAssignedToUser { get; set; }
        /// <summary>
        /// WMI Property IsClientAMT30Compatible
        /// </summary>
        public uint IsClientAmt30Compatible { get; set; }
        /// <summary>
        /// WMI Property IsMachineChangesPersisted
        /// </summary>
        public bool IsMachineChangesPersisted { get; set; }
        /// <summary>
        /// WMI Property IsPortableOperatingSystem
        /// </summary>
        public bool IsPortableOperatingSystem { get; set; }
        /// <summary>
        /// WMI Property IsVirtualMachine
        /// </summary>
        public bool IsVirtualMachine { get; set; }
        /// <summary>
        /// WMI Property IsWriteFilterCapable
        /// </summary>
        public bool IsWriteFilterCapable { get; set; }
        /// <summary>
        /// WMI Property LastLogonTimestamp
        /// </summary>
        public DateTime LastLogonTimestamp { get; set; }
        /// <summary>
        /// WMI Property LastLogonUserDomain
        /// </summary>
        public string LastLogonUserDomain { get; set; }
        /// <summary>
        /// WMI Property LastLogonUserName
        /// </summary>
        public string LastLogonUserName { get; set; }
        /// <summary>
        /// WMI Property MACAddresses
        /// </summary>
        public ICollection<string> MacAddresses { get; set; }
        /// <summary>
        /// WMI Property ManagementAuthority
        /// </summary>
        public uint ManagementAuthority { get; set; }
        /// <summary>
        /// WMI Property MDMComplianceStatus
        /// </summary>
        public string MdmComplianceStatus { get; set; }
        /// <summary>
        /// WMI Property MDMDeviceCategoryID
        /// </summary>
        public string MdmDeviceCategoryId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NetbiosName
        /// </summary>
        public string NetbiosName { get; set; }
        /// <summary>
        /// WMI Property ObjectGUID
        /// </summary>
        public ICollection<byte> ObjectGuid { get; set; }
        /// <summary>
        /// WMI Property Obsolete
        /// </summary>
        public uint Obsolete { get; set; }
        /// <summary>
        /// WMI Property OperatingSystemNameandVersion
        /// </summary>
        public string OperatingSystemNameandVersion { get; set; }
        /// <summary>
        /// WMI Property OSBranch
        /// </summary>
        public string OsBranch { get; set; }
        /// <summary>
        /// WMI Property PreviousSMSUUID
        /// </summary>
        public string PreviousSmsuuid { get; set; }
        /// <summary>
        /// WMI Property PrimaryGroupID
        /// </summary>
        public uint PrimaryGroupId { get; set; }
        /// <summary>
        /// WMI Property PublisherDeviceID
        /// </summary>
        public string PublisherDeviceId { get; set; }
        /// <summary>
        /// WMI Property ResourceDomainORWorkgroup
        /// </summary>
        public string ResourceDomainOrWorkgroup { get; set; }
        /// <summary>
        /// WMI Property ResourceId
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property ResourceNames
        /// </summary>
        public ICollection<string> ResourceNames { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public uint ResourceType { get; set; }
        /// <summary>
        /// WMI Property SecurityGroupName
        /// </summary>
        public ICollection<string> SecurityGroupName { get; set; }
        /// <summary>
        /// WMI Property SenseID
        /// </summary>
        public string SenseId { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// WMI Property SID
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// WMI Property SMBIOSGUID
        /// </summary>
        public string Smbiosguid { get; set; }
        /// <summary>
        /// WMI Property SMSAssignedSites
        /// </summary>
        public ICollection<string> SmsAssignedSites { get; set; }
        /// <summary>
        /// WMI Property SMSInstalledSites
        /// </summary>
        public ICollection<string> SmsInstalledSites { get; set; }
        /// <summary>
        /// WMI Property SMSResidentSites
        /// </summary>
        public ICollection<string> SmsResidentSites { get; set; }
        /// <summary>
        /// WMI Property SMSUniqueIdentifier
        /// </summary>
        public string SmsUniqueIdentifier { get; set; }
        /// <summary>
        /// WMI Property SMSUUIDChangeDate
        /// </summary>
        public DateTime SmsuuidChangeDate { get; set; }
        /// <summary>
        /// WMI Property SNMPCommunityName
        /// </summary>
        public string SnmpCommunityName { get; set; }
        /// <summary>
        /// WMI Property SuppressAutoProvision
        /// </summary>
        public uint SuppressAutoProvision { get; set; }
        /// <summary>
        /// WMI Property SystemContainerName
        /// </summary>
        public ICollection<string> SystemContainerName { get; set; }
        /// <summary>
        /// WMI Property SystemGroupName
        /// </summary>
        public ICollection<string> SystemGroupName { get; set; }
        /// <summary>
        /// WMI Property SystemOUName
        /// </summary>
        public ICollection<string> SystemOuName { get; set; }
        /// <summary>
        /// WMI Property SystemRoles
        /// </summary>
        public ICollection<string> SystemRoles { get; set; }
        /// <summary>
        /// WMI Property Unknown
        /// </summary>
        public uint Unknown { get; set; }
        /// <summary>
        /// WMI Property UserAccountControl
        /// </summary>
        public uint UserAccountControl { get; set; }
        /// <summary>
        /// WMI Property VirtualMachineHostName
        /// </summary>
        public string VirtualMachineHostName { get; set; }
        /// <summary>
        /// WMI Property VirtualMachineType
        /// </summary>
        public uint VirtualMachineType { get; set; }
        /// <summary>
        /// WMI Property WipeStatus
        /// </summary>
        public uint WipeStatus { get; set; }
        /// <summary>
        /// WMI Property WTGUniqueKey
        /// </summary>
        public string WtgUniqueKey { get; set; }
    }
}
