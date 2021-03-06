using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MigrationCollectionInfo
    /// </summary>
    [WmiClass(Name = "SMS_MigrationCollectionInfo")]
    public class SmsMigrationCollectionInfo
    {
        /// <summary>
        /// WMI static method <c>GetClientsCountByCollections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionIDs">WMI Property <c>collectionIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetClientsCountByCollectionsDelegate(WmiContext wmiContext, ICollection<string> collectionIDs = default);
        /// <summary>
        /// WMI static method <c>GetClientsCountByCollections</c>.
        /// </summary>
        public static GetClientsCountByCollectionsDelegate GetClientsCountByCollections;
        /// <summary>
        /// WMI Property ChildCount
        /// </summary>
        public uint ChildCount { get; set; }
        /// <summary>
        /// WMI Property Children
        /// </summary>
        public string Children { get; set; }
        /// <summary>
        /// WMI Property CollectionEntityID
        /// </summary>
        public uint CollectionEntityId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property CollectionType
        /// </summary>
        public uint CollectionType { get; set; }
        /// <summary>
        /// WMI Property Count
        /// </summary>
        public uint Count { get; set; }
        /// <summary>
        /// WMI Property IsTop
        /// </summary>
        public bool IsTop { get; set; }
        /// <summary>
        /// WMI Property LimitToCount
        /// </summary>
        public uint LimitToCount { get; set; }
        /// <summary>
        /// WMI Property LimitTos
        /// </summary>
        public string LimitTos { get; set; }
        /// <summary>
        /// WMI Property SiteCodeCount
        /// </summary>
        public uint SiteCodeCount { get; set; }
        /// <summary>
        /// WMI Property SiteCodes
        /// </summary>
        public string SiteCodes { get; set; }
        /// <summary>
        /// WMI Property SourceSiteCollectionID
        /// </summary>
        public string SourceSiteCollectionId { get; set; }
        /// <summary>
        /// WMI Property SourceSiteID
        /// </summary>
        public uint SourceSiteId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
    }
}
