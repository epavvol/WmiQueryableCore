using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationDashboard
    /// </summary>
    [WmiClass(Name = "SMS_MigrationDashboard")]
    public class SmsMigrationDashboard
    {
        /// <summary>
        /// WMI Property ClientMigrationLastUpdated
        /// </summary>
        public DateTime ClientMigrationLastUpdated { get; set; }
        /// <summary>
        /// WMI Property JobStatisticsLastUpdated
        /// </summary>
        public DateTime JobStatisticsLastUpdated { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSynced
        /// </summary>
        public DateTime LastSuccessfulSynced { get; set; }
        /// <summary>
        /// WMI Property NumOfDestinationSites
        /// </summary>
        public uint NumOfDestinationSites { get; set; }
        /// <summary>
        /// WMI Property NumOfJobCompleted
        /// </summary>
        public uint NumOfJobCompleted { get; set; }
        /// <summary>
        /// WMI Property NumOfJobFailed
        /// </summary>
        public uint NumOfJobFailed { get; set; }
        /// <summary>
        /// WMI Property NumOfJobInProgress
        /// </summary>
        public uint NumOfJobInProgress { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteClients
        /// </summary>
        public uint NumOfSourceSiteClients { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteClientsExcluded
        /// </summary>
        public uint NumOfSourceSiteClientsExcluded { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteClientsMigrated
        /// </summary>
        public uint NumOfSourceSiteClientsMigrated { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteClientsRemaining
        /// </summary>
        public uint NumOfSourceSiteClientsRemaining { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteObjects
        /// </summary>
        public uint NumOfSourceSiteObjects { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteObjectsExcluded
        /// </summary>
        public uint NumOfSourceSiteObjectsExcluded { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteObjectsMigrated
        /// </summary>
        public uint NumOfSourceSiteObjectsMigrated { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSiteObjectsRemaining
        /// </summary>
        public uint NumOfSourceSiteObjectsRemaining { get; set; }
        /// <summary>
        /// WMI Property NumOfSourceSites
        /// </summary>
        public uint NumOfSourceSites { get; set; }
        /// <summary>
        /// WMI Property ObjectMigrationLastUpdated
        /// </summary>
        public DateTime ObjectMigrationLastUpdated { get; set; }
        /// <summary>
        /// WMI Property SourceCentralSiteFQDN
        /// </summary>
        public string SourceCentralSiteFqdn { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
