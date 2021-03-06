using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.CIMv2.Classes
{
    /// <summary>
    /// Namespace: root\CIMv2
    /// WMI Class: Win32_NTDomain
    /// </summary>
    [WmiClass(Name = "Win32_NTDomain")]
    public class Win32NtDomain
    {
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// WMI Property ClientSiteName
        /// </summary>
        public string ClientSiteName { get; set; }

        /// <summary>
        /// WMI Property CreationClassName
        /// </summary>
        public string CreationClassName { get; set; }

        /// <summary>
        /// WMI Property DcSiteName
        /// </summary>
        public string DcSiteName { get; set; }

        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// WMI Property DnsForestName
        /// </summary>
        public string DnsForestName { get; set; }

        /// <summary>
        /// WMI Property DomainControllerAddress
        /// </summary>
        public string DomainControllerAddress { get; set; }

        /// <summary>
        /// WMI Property DomainControllerAddressType
        /// </summary>
        public int DomainControllerAddressType { get; set; }

        /// <summary>
        /// WMI Property DomainControllerName
        /// </summary>
        public string DomainControllerName { get; set; }

        /// <summary>
        /// WMI Property DomainGuid
        /// </summary>
        public string DomainGuid { get; set; }

        /// <summary>
        /// WMI Property DomainName
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// WMI Property DSDirectoryServiceFlag
        /// </summary>
        public bool DsDirectoryServiceFlag { get; set; }

        /// <summary>
        /// WMI Property DSDnsControllerFlag
        /// </summary>
        public bool DsDnsControllerFlag { get; set; }

        /// <summary>
        /// WMI Property DSDnsDomainFlag
        /// </summary>
        public bool DsDnsDomainFlag { get; set; }

        /// <summary>
        /// WMI Property DSDnsForestFlag
        /// </summary>
        public bool DsDnsForestFlag { get; set; }

        /// <summary>
        /// WMI Property DSGlobalCatalogFlag
        /// </summary>
        public bool DsGlobalCatalogFlag { get; set; }

        /// <summary>
        /// WMI Property DSKerberosDistributionCenterFlag
        /// </summary>
        public bool DsKerberosDistributionCenterFlag { get; set; }

        /// <summary>
        /// WMI Property DSPrimaryDomainControllerFlag
        /// </summary>
        public bool DsPrimaryDomainControllerFlag { get; set; }

        /// <summary>
        /// WMI Property DSTimeServiceFlag
        /// </summary>
        public bool DsTimeServiceFlag { get; set; }

        /// <summary>
        /// WMI Property DSWritableFlag
        /// </summary>
        public bool DsWritableFlag { get; set; }

        /// <summary>
        /// WMI Property InstallDate
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// WMI Property NameFormat
        /// </summary>
        public string NameFormat { get; set; }

        /// <summary>
        /// WMI Property PrimaryOwnerContact
        /// </summary>
        public string PrimaryOwnerContact { get; set; }

        /// <summary>
        /// WMI Property PrimaryOwnerName
        /// </summary>
        public string PrimaryOwnerName { get; set; }

        /// <summary>
        /// WMI Property Roles
        /// </summary>
        public ICollection<string> Roles { get; set; }

        /// <summary>
        /// WMI Property Status
        /// </summary>
        public string Status { get; set; }
    }
}