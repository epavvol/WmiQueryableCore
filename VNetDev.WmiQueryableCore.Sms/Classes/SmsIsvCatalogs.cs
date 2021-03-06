using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ISVCatalogs
    /// </summary>
    [WmiClass(Name = "SMS_ISVCatalogs")]
    public class SmsIsvCatalogs
    {
        /// <summary>
        /// WMI static method <c>ManageSubscription</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="id">WMI Property <c>ID</c> of type <c>string</c>.</param>
        /// <param name="signingCertificate">WMI Property <c>SigningCertificate</c> of type <c>string</c>.</param>
        /// <param name="subscribe">WMI Property <c>Subscribe</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ManageSubscriptionDelegate(WmiContext wmiContext, string id = default, string signingCertificate = default, bool subscribe = default);
        /// <summary>
        /// WMI static method <c>ManageSubscription</c>.
        /// </summary>
        public static ManageSubscriptionDelegate ManageSubscription;
        
        /// <summary>
        /// WMI static method <c>SyncCatalogs</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="catalogIDs">WMI Property <c>CatalogIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SyncCatalogsDelegate(WmiContext wmiContext, ICollection<string> catalogIDs = default);
        /// <summary>
        /// WMI static method <c>SyncCatalogs</c>.
        /// </summary>
        public static SyncCatalogsDelegate SyncCatalogs;
        
        /// <summary>
        /// WMI static method <c>PublishContent</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="updateIDs">WMI Property <c>UpdateIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint PublishContentDelegate(WmiContext wmiContext, ICollection<string> updateIDs = default);
        /// <summary>
        /// WMI static method <c>PublishContent</c>.
        /// </summary>
        public static PublishContentDelegate PublishContent;
        /// <summary>
        /// WMI Property DateLastModified
        /// </summary>
        public DateTime DateLastModified { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DownloadUrl
        /// </summary>
        public string DownloadUrl { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public int Flags { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LastScheduledSyncStart
        /// </summary>
        public DateTime LastScheduledSyncStart { get; set; }
        /// <summary>
        /// WMI Property LastSyncComplete
        /// </summary>
        public DateTime LastSyncComplete { get; set; }
        /// <summary>
        /// WMI Property LastSyncHash
        /// </summary>
        public string LastSyncHash { get; set; }
        /// <summary>
        /// WMI Property LastSyncStatus
        /// </summary>
        public int LastSyncStatus { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PublisherName
        /// </summary>
        public string PublisherName { get; set; }
        /// <summary>
        /// WMI Property ScheduleToken
        /// </summary>
        public string ScheduleToken { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Source
        /// </summary>
        public int Source { get; set; }
        /// <summary>
        /// WMI Property SupportContact
        /// </summary>
        public string SupportContact { get; set; }
        /// <summary>
        /// WMI Property SupportUrl
        /// </summary>
        public string SupportUrl { get; set; }
        /// <summary>
        /// WMI Property SyncEnabled
        /// </summary>
        public bool SyncEnabled { get; set; }
    }
}
