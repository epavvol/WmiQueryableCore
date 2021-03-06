using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationSourceSite
    /// </summary>
    [WmiClass(Name = "SMS_MigrationSourceSite")]
    public class SmsMigrationSourceSite
    {
        /// <summary>
        /// WMI Property FQDN
        /// </summary>
        public string Fqdn { get; set; }
        /// <summary>
        /// WMI Property IsCentral
        /// </summary>
        public bool IsCentral { get; set; }
        /// <summary>
        /// WMI Property IsConfigured
        /// </summary>
        public bool IsConfigured { get; set; }
        /// <summary>
        /// WMI Property IsDecommissioned
        /// </summary>
        public bool IsDecommissioned { get; set; }
        /// <summary>
        /// WMI Property IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// WMI Property ParentSiteCode
        /// </summary>
        public string ParentSiteCode { get; set; }
        /// <summary>
        /// WMI Property ParentSiteServer
        /// </summary>
        public string ParentSiteServer { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteID
        /// </summary>
        public uint SiteId { get; set; }
        /// <summary>
        /// WMI Property SiteType
        /// </summary>
        public uint SiteType { get; set; }
        /// <summary>
        /// WMI Property SourceSiteFQDN
        /// </summary>
        public string SourceSiteFqdn { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
