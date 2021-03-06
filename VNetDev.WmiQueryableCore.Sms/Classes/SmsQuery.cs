using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Query
    /// </summary>
    [WmiClass(Name = "SMS_Query")]
    public class SmsQuery
    {
        /// <summary>
        /// WMI method <c>CreateCCRs</c> describing delegate.
        /// <param name="clientType">WMI Property <c>ClientType</c> of type <c>int</c>.</param>
        /// <param name="forced">WMI Property <c>Forced</c> of type <c>bool</c>.</param>
        /// <param name="forceReinstall">WMI Property <c>ForceReinstall</c> of type <c>bool</c>.</param>
        /// <param name="informationOnly">WMI Property <c>InformationOnly</c> of type <c>bool</c>.</param>
        /// <param name="pushEvenIfDc">WMI Property <c>PushEvenIfDC</c> of type <c>bool</c>.</param>
        /// <param name="pushOnlyAssignedClients">WMI Property <c>PushOnlyAssignedClients</c> of type <c>bool</c>.</param>
        /// <param name="pushSiteCode">WMI Property <c>PushSiteCode</c> of type <c>string</c>.</param>
        /// <param name="specifySiteCode">WMI Property <c>SpecifySiteCode</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CreateCcRsDelegate(int clientType = default, bool forced = default, bool forceReinstall = default, bool informationOnly = default, bool pushEvenIfDc = default, bool pushOnlyAssignedClients = default, string pushSiteCode = default, bool specifySiteCode = default);
        /// <summary>
        /// WMI method <c>CreateCCRs</c>.
        /// </summary>
        public CreateCcRsDelegate CreateCcRs;
        
        /// <summary>
        /// WMI method <c>FindResourceSite</c> describing delegate.
        /// <param name="includeSubCollections">WMI Property <c>IncludeSubCollections</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint FindResourceSiteDelegate(bool includeSubCollections = default);
        /// <summary>
        /// WMI method <c>FindResourceSite</c>.
        /// </summary>
        public FindResourceSiteDelegate FindResourceSite;
        /// <summary>
        /// WMI Property Comments
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// WMI Property Expression
        /// </summary>
        public string Expression { get; set; }
        /// <summary>
        /// WMI Property LimitToCollectionID
        /// </summary>
        public string LimitToCollectionId { get; set; }
        /// <summary>
        /// WMI Property LocalizedCategoryInstanceNames
        /// </summary>
        public ICollection<string> LocalizedCategoryInstanceNames { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property QueryID
        /// </summary>
        public string QueryId { get; set; }
        /// <summary>
        /// WMI Property ResultAliasNames
        /// </summary>
        public ICollection<string> ResultAliasNames { get; set; }
        /// <summary>
        /// WMI Property ResultColumnsNames
        /// </summary>
        public ICollection<string> ResultColumnsNames { get; set; }
        /// <summary>
        /// WMI Property TargetClassName
        /// </summary>
        public string TargetClassName { get; set; }
    }
}
