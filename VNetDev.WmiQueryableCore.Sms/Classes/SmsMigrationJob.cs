using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationJob
    /// </summary>
    [WmiClass(Name = "SMS_MigrationJob")]
    public class SmsMigrationJob
    {
        /// <summary>
        /// WMI method <c>Start</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint StartDelegate();
        /// <summary>
        /// WMI method <c>Start</c>.
        /// </summary>
        public StartDelegate Start;
        
        /// <summary>
        /// WMI method <c>Stop</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint StopDelegate();
        /// <summary>
        /// WMI method <c>Stop</c>.
        /// </summary>
        public StopDelegate Stop;
        /// <summary>
        /// WMI Property AdditionalConfiguration
        /// </summary>
        public string AdditionalConfiguration { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CustomBootImagePackage_x64
        /// </summary>
        [WmiProperty(Name = "CustomBootImagePackage_x64")]
        public string CustomBootImagePackageX64 { get; set; }
        /// <summary>
        /// WMI Property CustomBootImagePackage_x86
        /// </summary>
        [WmiProperty(Name = "CustomBootImagePackage_x86")]
        public string CustomBootImagePackageX86 { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateEnded
        /// </summary>
        public DateTime DateEnded { get; set; }
        /// <summary>
        /// WMI Property DateLastUpdated
        /// </summary>
        public DateTime DateLastUpdated { get; set; }
        /// <summary>
        /// WMI Property DateNextRun
        /// </summary>
        public DateTime DateNextRun { get; set; }
        /// <summary>
        /// WMI Property DateStarted
        /// </summary>
        public DateTime DateStarted { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DestinationSiteCode
        /// </summary>
        public string DestinationSiteCode { get; set; }
        /// <summary>
        /// WMI Property DestinationSiteFQDN
        /// </summary>
        public string DestinationSiteFqdn { get; set; }
        /// <summary>
        /// WMI Property DisableAdvertisements
        /// </summary>
        public bool DisableAdvertisements { get; set; }
        /// <summary>
        /// WMI Property FailedObjectNumber
        /// </summary>
        public uint FailedObjectNumber { get; set; }
        /// <summary>
        /// WMI Property JobID
        /// </summary>
        public uint JobId { get; set; }
        /// <summary>
        /// WMI Property JobName
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// WMI Property MigratedObjectNumber
        /// </summary>
        public uint MigratedObjectNumber { get; set; }
        /// <summary>
        /// WMI Property MigrateWithFolders
        /// </summary>
        public bool MigrateWithFolders { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ResolveObjectConflictOption
        /// </summary>
        public uint ResolveObjectConflictOption { get; set; }
        /// <summary>
        /// WMI Property ScheduleToken
        /// </summary>
        public string ScheduleToken { get; set; }
        /// <summary>
        /// WMI Property ScopeIDs
        /// </summary>
        public ICollection<string> ScopeIDs { get; set; }
        /// <summary>
        /// WMI Property SkippedObjectNumber
        /// </summary>
        public uint SkippedObjectNumber { get; set; }
        /// <summary>
        /// WMI Property SourceCollectionIDs
        /// </summary>
        public ICollection<string> SourceCollectionIDs { get; set; }
        /// <summary>
        /// WMI Property SourceObjectIDs
        /// </summary>
        public ICollection<uint> SourceObjectIDs { get; set; }
        /// <summary>
        /// WMI Property SourceSiteCode
        /// </summary>
        public string SourceSiteCode { get; set; }
        /// <summary>
        /// WMI Property SourceSiteFQDN
        /// </summary>
        public string SourceSiteFqdn { get; set; }
        /// <summary>
        /// WMI Property SourceSiteID
        /// </summary>
        public uint SourceSiteId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property TotalObjectNumber
        /// </summary>
        public uint TotalObjectNumber { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
