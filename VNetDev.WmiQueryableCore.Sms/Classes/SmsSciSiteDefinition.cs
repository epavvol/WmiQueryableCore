using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_SiteDefinition
    /// </summary>
    [WmiClass(Name = "SMS_SCI_SiteDefinition")]
    public class SmsSciSiteDefinition
    {
        /// <summary>
        /// WMI Property AddressPublicKey
        /// </summary>
        public string AddressPublicKey { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property InstallDirectory
        /// </summary>
        public string InstallDirectory { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property ParentSiteCode
        /// </summary>
        public string ParentSiteCode { get; set; }
        /// <summary>
        /// WMI Property PropLists
        /// </summary>
        public  ICollection<SmsEmbeddedPropertyList> PropLists { get; set; }
        /// <summary>
        /// WMI Property Props
        /// </summary>
        public  ICollection<SmsEmbeddedProperty> Props { get; set; }
        /// <summary>
        /// WMI Property ServiceAccount
        /// </summary>
        public string ServiceAccount { get; set; }
        /// <summary>
        /// WMI Property ServiceAccountDomain
        /// </summary>
        public string ServiceAccountDomain { get; set; }
        /// <summary>
        /// WMI Property ServiceAccountPassword
        /// </summary>
        public string ServiceAccountPassword { get; set; }
        /// <summary>
        /// WMI Property ServiceExchangeKey
        /// </summary>
        public string ServiceExchangeKey { get; set; }
        /// <summary>
        /// WMI Property ServicePlaintextAccount
        /// </summary>
        public string ServicePlaintextAccount { get; set; }
        /// <summary>
        /// WMI Property ServicePublicKey
        /// </summary>
        public string ServicePublicKey { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property SiteServerDomain
        /// </summary>
        public string SiteServerDomain { get; set; }
        /// <summary>
        /// WMI Property SiteServerName
        /// </summary>
        public string SiteServerName { get; set; }
        /// <summary>
        /// WMI Property SiteServerPlatform
        /// </summary>
        public string SiteServerPlatform { get; set; }
        /// <summary>
        /// WMI Property SiteType
        /// </summary>
        public uint SiteType { get; set; }
        /// <summary>
        /// WMI Property SQLAccount
        /// </summary>
        public string SqlAccount { get; set; }
        /// <summary>
        /// WMI Property SQLAccountPassword
        /// </summary>
        public string SqlAccountPassword { get; set; }
        /// <summary>
        /// WMI Property SQLDatabaseName
        /// </summary>
        public string SqlDatabaseName { get; set; }
        /// <summary>
        /// WMI Property SQLPublicKey
        /// </summary>
        public string SqlPublicKey { get; set; }
        /// <summary>
        /// WMI Property SQLServerName
        /// </summary>
        public string SqlServerName { get; set; }
    }
}
