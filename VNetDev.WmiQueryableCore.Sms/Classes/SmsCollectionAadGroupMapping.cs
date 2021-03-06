using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CollectionAADGroupMapping
    /// </summary>
    [WmiClass(Name = "SMS_CollectionAADGroupMapping")]
    public class SmsCollectionAadGroupMapping
    {
        /// <summary>
        /// WMI static method <c>AddCollectionAADGroupMapping</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="aadGroupId">WMI Property <c>AADGroupID</c> of type <c>string</c>.</param>
        /// <param name="aadGroupName">WMI Property <c>AADGroupName</c> of type <c>string</c>.</param>
        /// <param name="cloudServiceId">WMI Property <c>CloudServiceID</c> of type <c>uint</c>.</param>
        /// <param name="collectionSiteId">WMI Property <c>CollectionSiteID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddCollectionAadGroupMappingDelegate(WmiContext wmiContext, string aadGroupId = default, string aadGroupName = default, uint cloudServiceId = default, string collectionSiteId = default);
        /// <summary>
        /// WMI static method <c>AddCollectionAADGroupMapping</c>.
        /// </summary>
        public static AddCollectionAadGroupMappingDelegate AddCollectionAadGroupMapping;
        
        /// <summary>
        /// WMI static method <c>RemoveCollectionAADGroupMapping</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="aadGroupId">WMI Property <c>AADGroupID</c> of type <c>string</c>.</param>
        /// <param name="cloudServiceId">WMI Property <c>CloudServiceID</c> of type <c>uint</c>.</param>
        /// <param name="collectionSiteId">WMI Property <c>CollectionSiteID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RemoveCollectionAadGroupMappingDelegate(WmiContext wmiContext, string aadGroupId = default, uint cloudServiceId = default, string collectionSiteId = default);
        /// <summary>
        /// WMI static method <c>RemoveCollectionAADGroupMapping</c>.
        /// </summary>
        public static RemoveCollectionAadGroupMappingDelegate RemoveCollectionAadGroupMapping;
        
        /// <summary>
        /// WMI static method <c>ConfigSyncSettings</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionSiteId">WMI Property <c>CollectionSiteID</c> of type <c>string</c>.</param>
        /// <param name="flags">WMI Property <c>Flags</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint ConfigSyncSettingsDelegate(WmiContext wmiContext, string collectionSiteId = default, uint flags = default);
        /// <summary>
        /// WMI static method <c>ConfigSyncSettings</c>.
        /// </summary>
        public static ConfigSyncSettingsDelegate ConfigSyncSettings;
        /// <summary>
        /// WMI Property AADGroupID
        /// </summary>
        public string AadGroupId { get; set; }
        /// <summary>
        /// WMI Property AADGroupName
        /// </summary>
        public string AadGroupName { get; set; }
        /// <summary>
        /// WMI Property CloudServiceID
        /// </summary>
        public uint CloudServiceId { get; set; }
        /// <summary>
        /// WMI Property CollectionSiteID
        /// </summary>
        public string CollectionSiteId { get; set; }
        /// <summary>
        /// WMI Property Flag
        /// </summary>
        public uint Flag { get; set; }
        /// <summary>
        /// WMI Property LastSyncStatus
        /// </summary>
        public uint LastSyncStatus { get; set; }
        /// <summary>
        /// WMI Property LastSyncTime
        /// </summary>
        public DateTime LastSyncTime { get; set; }
    }
}
