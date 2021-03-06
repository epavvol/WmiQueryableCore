using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_OMSCollection
    /// </summary>
    [WmiClass(Name = "SMS_OMSCollection")]
    public class SmsOmsCollection
    {
        /// <summary>
        /// WMI static method <c>UpdateOMSCollections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionIDs">WMI Property <c>CollectionIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="workspaceId">WMI Property <c>WorkspaceID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateOmsCollectionsDelegate(WmiContext wmiContext, ICollection<string> collectionIDs = default, string workspaceId = default);
        /// <summary>
        /// WMI static method <c>UpdateOMSCollections</c>.
        /// </summary>
        public static UpdateOmsCollectionsDelegate UpdateOmsCollections;
        
        /// <summary>
        /// WMI static method <c>AddOMSCollections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionIDs">WMI Property <c>CollectionIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="workspaceId">WMI Property <c>WorkspaceID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddOmsCollectionsDelegate(WmiContext wmiContext, ICollection<string> collectionIDs = default, string workspaceId = default);
        /// <summary>
        /// WMI static method <c>AddOMSCollections</c>.
        /// </summary>
        public static AddOmsCollectionsDelegate AddOmsCollections;
        
        /// <summary>
        /// WMI static method <c>RemoveOMSCollections</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionIDs">WMI Property <c>CollectionIDs</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="workspaceId">WMI Property <c>WorkspaceID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveOmsCollectionsDelegate(WmiContext wmiContext, ICollection<string> collectionIDs = default, string workspaceId = default);
        /// <summary>
        /// WMI static method <c>RemoveOMSCollections</c>.
        /// </summary>
        public static RemoveOmsCollectionsDelegate RemoveOmsCollections;
        
        /// <summary>
        /// WMI static method <c>RemoveOMSCollectionsAll</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="workspaceId">WMI Property <c>WorkspaceID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RemoveOmsCollectionsAllDelegate(WmiContext wmiContext, string workspaceId = default);
        /// <summary>
        /// WMI static method <c>RemoveOMSCollectionsAll</c>.
        /// </summary>
        public static RemoveOmsCollectionsAllDelegate RemoveOmsCollectionsAll;
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
    }
}
