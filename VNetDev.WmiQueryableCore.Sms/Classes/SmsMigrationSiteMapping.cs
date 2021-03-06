using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationSiteMapping
    /// </summary>
    [WmiClass(Name = "SMS_MigrationSiteMapping")]
    public class SmsMigrationSiteMapping
    {
        /// <summary>
        /// WMI static method <c>ActivateHierarchy</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="destinationSiteCode">WMI Property <c>destinationSiteCode</c> of type <c>string</c>.</param>
        /// <param name="scheduleToken">WMI Property <c>scheduleToken</c> of type <c>string</c>.</param>
        /// <param name="sourceSite">WMI Property <c>sourceSite</c> of type <c>string</c>.</param>
        /// <param name="sqlAccount">WMI Property <c>sqlAccount</c> of type <c>string</c>.</param>
        /// <param name="wmiAccount">WMI Property <c>wmiAccount</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ActivateHierarchyDelegate(WmiContext wmiContext, string destinationSiteCode = default, string scheduleToken = default, string sourceSite = default, string sqlAccount = default, string wmiAccount = default);
        /// <summary>
        /// WMI static method <c>ActivateHierarchy</c>.
        /// </summary>
        public static ActivateHierarchyDelegate ActivateHierarchy;
        
        /// <summary>
        /// WMI static method <c>CleanupHierarchyData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="siteId">WMI Property <c>siteID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CleanupHierarchyDataDelegate(WmiContext wmiContext, uint siteId = default);
        /// <summary>
        /// WMI static method <c>CleanupHierarchyData</c>.
        /// </summary>
        public static CleanupHierarchyDataDelegate CleanupHierarchyData;
        
        /// <summary>
        /// WMI method <c>Sync</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SyncDelegate();
        /// <summary>
        /// WMI method <c>Sync</c>.
        /// </summary>
        public SyncDelegate Sync;
        
        /// <summary>
        /// WMI method <c>CheckDecommissionState</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CheckDecommissionStateDelegate();
        /// <summary>
        /// WMI method <c>CheckDecommissionState</c>.
        /// </summary>
        public CheckDecommissionStateDelegate CheckDecommissionState;
        
        /// <summary>
        /// WMI method <c>Decommission</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DecommissionDelegate();
        /// <summary>
        /// WMI method <c>Decommission</c>.
        /// </summary>
        public DecommissionDelegate Decommission;
        
        /// <summary>
        /// WMI method <c>Resuscitate</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ResuscitateDelegate();
        /// <summary>
        /// WMI method <c>Resuscitate</c>.
        /// </summary>
        public ResuscitateDelegate Resuscitate;
        /// <summary>
        /// WMI Property Account
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// WMI Property AccountForSql
        /// </summary>
        public string AccountForSql { get; set; }
        /// <summary>
        /// WMI Property ContentDestination
        /// </summary>
        public string ContentDestination { get; set; }
        /// <summary>
        /// WMI Property DateLastBegin
        /// </summary>
        public DateTime DateLastBegin { get; set; }
        /// <summary>
        /// WMI Property DateLastSynced
        /// </summary>
        public DateTime DateLastSynced { get; set; }
        /// <summary>
        /// WMI Property DateLastUpdated
        /// </summary>
        public DateTime DateLastUpdated { get; set; }
        /// <summary>
        /// WMI Property DateNextRun
        /// </summary>
        public DateTime DateNextRun { get; set; }
        /// <summary>
        /// WMI Property DestinationSiteCode
        /// </summary>
        public string DestinationSiteCode { get; set; }
        /// <summary>
        /// WMI Property DestinationSiteFQDN
        /// </summary>
        public string DestinationSiteFqdn { get; set; }
        /// <summary>
        /// WMI Property EnableDPSharing
        /// </summary>
        public bool EnableDpSharing { get; set; }
        /// <summary>
        /// WMI Property IsCentral
        /// </summary>
        public bool IsCentral { get; set; }
        /// <summary>
        /// WMI Property IsDecommissioned
        /// </summary>
        public bool IsDecommissioned { get; set; }
        /// <summary>
        /// WMI Property IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// WMI Property JobIDs
        /// </summary>
        public ICollection<uint> JobIDs { get; set; }
        /// <summary>
        /// WMI Property MigratedClientNumber
        /// </summary>
        public uint MigratedClientNumber { get; set; }
        /// <summary>
        /// WMI Property MigratedObjectNumber
        /// </summary>
        public uint MigratedObjectNumber { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ParentSiteCode
        /// </summary>
        public string ParentSiteCode { get; set; }
        /// <summary>
        /// WMI Property ParentSiteServer
        /// </summary>
        public string ParentSiteServer { get; set; }
        /// <summary>
        /// WMI Property ScheduleToken
        /// </summary>
        public string ScheduleToken { get; set; }
        /// <summary>
        /// WMI Property SiteMappingID
        /// </summary>
        public uint SiteMappingId { get; set; }
        /// <summary>
        /// WMI Property SourceSiteCode
        /// </summary>
        public string SourceSiteCode { get; set; }
        /// <summary>
        /// WMI Property SourceSiteFQDN
        /// </summary>
        public string SourceSiteFqdn { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property SyncedEntities
        /// </summary>
        public ICollection<uint> SyncedEntities { get; set; }
        /// <summary>
        /// WMI Property TotalClientNumber
        /// </summary>
        public uint TotalClientNumber { get; set; }
        /// <summary>
        /// WMI Property TotalObjectNumber
        /// </summary>
        public uint TotalObjectNumber { get; set; }
    }
}
