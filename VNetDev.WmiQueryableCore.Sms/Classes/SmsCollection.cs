using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Collection
    /// </summary>
    [WmiClass(Name = "SMS_Collection")]
    public class SmsCollection
    {
        /// <summary>
        /// WMI method <c>AddMembershipRule</c> describing delegate.
        /// <param name="collectionRule">WMI Property <c>collectionRule</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddMembershipRuleDelegate( SmsCollectionRule collectionRule = default);
        /// <summary>
        /// WMI method <c>AddMembershipRule</c>.
        /// </summary>
        public AddMembershipRuleDelegate AddMembershipRule;
        
        /// <summary>
        /// WMI method <c>DeleteMembershipRule</c> describing delegate.
        /// <param name="collectionRule">WMI Property <c>collectionRule</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteMembershipRuleDelegate( SmsCollectionRule collectionRule = default);
        /// <summary>
        /// WMI method <c>DeleteMembershipRule</c>.
        /// </summary>
        public DeleteMembershipRuleDelegate DeleteMembershipRule;
        
        /// <summary>
        /// WMI method <c>AddMembershipRules</c> describing delegate.
        /// <param name="collectionRules">WMI Property <c>collectionRules</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AddMembershipRulesDelegate( ICollection<SmsCollectionRule> collectionRules = default);
        /// <summary>
        /// WMI method <c>AddMembershipRules</c>.
        /// </summary>
        public AddMembershipRulesDelegate AddMembershipRules;
        
        /// <summary>
        /// WMI method <c>DeleteMembershipRules</c> describing delegate.
        /// <param name="collectionRules">WMI Property <c>collectionRules</c> of type <c>System.Object[]</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteMembershipRulesDelegate( ICollection<SmsCollectionRule> collectionRules = default);
        /// <summary>
        /// WMI method <c>DeleteMembershipRules</c>.
        /// </summary>
        public DeleteMembershipRulesDelegate DeleteMembershipRules;
        
        /// <summary>
        /// WMI method <c>RequestRefresh</c> describing delegate.
        /// <param name="includesubcollections">WMI Property <c>includesubcollections</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RequestRefreshDelegate(bool includesubcollections = default);
        /// <summary>
        /// WMI method <c>RequestRefresh</c>.
        /// </summary>
        public RequestRefreshDelegate RequestRefresh;
        
        /// <summary>
        /// WMI method <c>DeleteAllMembers</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteAllMembersDelegate();
        /// <summary>
        /// WMI method <c>DeleteAllMembers</c>.
        /// </summary>
        public DeleteAllMembersDelegate DeleteAllMembers;
        
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
        /// WMI method <c>CreateCCRs</c> describing delegate.
        /// <param name="clientType">WMI Property <c>ClientType</c> of type <c>int</c>.</param>
        /// <param name="forced">WMI Property <c>Forced</c> of type <c>bool</c>.</param>
        /// <param name="forceReinstall">WMI Property <c>ForceReinstall</c> of type <c>bool</c>.</param>
        /// <param name="includeSubCollections">WMI Property <c>IncludeSubCollections</c> of type <c>bool</c>.</param>
        /// <param name="informationOnly">WMI Property <c>InformationOnly</c> of type <c>bool</c>.</param>
        /// <param name="pushEvenIfDc">WMI Property <c>PushEvenIfDC</c> of type <c>bool</c>.</param>
        /// <param name="pushOnlyAssignedClients">WMI Property <c>PushOnlyAssignedClients</c> of type <c>bool</c>.</param>
        /// <param name="pushSiteCode">WMI Property <c>PushSiteCode</c> of type <c>string</c>.</param>
        /// <param name="specifySiteCode">WMI Property <c>SpecifySiteCode</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CreateCcRsDelegate(int clientType = default, bool forced = default, bool forceReinstall = default, bool includeSubCollections = default, bool informationOnly = default, bool pushEvenIfDc = default, bool pushOnlyAssignedClients = default, string pushSiteCode = default, bool specifySiteCode = default);
        /// <summary>
        /// WMI method <c>CreateCCRs</c>.
        /// </summary>
        public CreateCcRsDelegate CreateCcRs;
        
        /// <summary>
        /// WMI method <c>ClearLastNBSAdvForCollection</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClearLastNbsAdvForCollectionDelegate();
        /// <summary>
        /// WMI method <c>ClearLastNBSAdvForCollection</c>.
        /// </summary>
        public ClearLastNbsAdvForCollectionDelegate ClearLastNbsAdvForCollection;
        
        /// <summary>
        /// WMI method <c>ClearDeploymentLocksForCollection</c> describing delegate.
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClearDeploymentLocksForCollectionDelegate();
        /// <summary>
        /// WMI method <c>ClearDeploymentLocksForCollection</c>.
        /// </summary>
        public ClearDeploymentLocksForCollectionDelegate ClearDeploymentLocksForCollection;
        
        /// <summary>
        /// WMI method <c>UpdateVisibilityInEPDashBoard</c> describing delegate.
        /// <param name="visible">WMI Property <c>Visible</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdateVisibilityInEpDashBoardDelegate(bool visible = default);
        /// <summary>
        /// WMI method <c>UpdateVisibilityInEPDashBoard</c>.
        /// </summary>
        public UpdateVisibilityInEpDashBoardDelegate UpdateVisibilityInEpDashBoard;
        
        /// <summary>
        /// WMI static method <c>VerifyNoCircularDependencies</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="parentCollection">WMI Property <c>parentCollection</c> of type <c>object</c>.</param>
        /// <param name="subCollection">WMI Property <c>subCollection</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint VerifyNoCircularDependenciesDelegate(WmiContext wmiContext, object parentCollection = default, object subCollection = default);
        /// <summary>
        /// WMI static method <c>VerifyNoCircularDependencies</c>.
        /// </summary>
        public static VerifyNoCircularDependenciesDelegate VerifyNoCircularDependencies;
        
        /// <summary>
        /// WMI static method <c>GetNumResults</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collection">WMI Property <c>Collection</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetNumResultsDelegate(WmiContext wmiContext, object collection = default);
        /// <summary>
        /// WMI static method <c>GetNumResults</c>.
        /// </summary>
        public static GetNumResultsDelegate GetNumResults;
        
        /// <summary>
        /// WMI static method <c>GetTotalNumResults</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collection">WMI Property <c>Collection</c> of type <c>object</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetTotalNumResultsDelegate(WmiContext wmiContext, object collection = default);
        /// <summary>
        /// WMI static method <c>GetTotalNumResults</c>.
        /// </summary>
        public static GetTotalNumResultsDelegate GetTotalNumResults;
        
        /// <summary>
        /// WMI static method <c>GetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetNextIdDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>GetNextID</c>.
        /// </summary>
        public static GetNextIdDelegate GetNextId;
        
        /// <summary>
        /// WMI static method <c>SetNextID</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nextId">WMI Property <c>NextID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetNextIdDelegate(WmiContext wmiContext, uint nextId = default);
        /// <summary>
        /// WMI static method <c>SetNextID</c>.
        /// </summary>
        public static SetNextIdDelegate SetNextId;
        
        /// <summary>
        /// WMI static method <c>FindMachineSite</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint FindMachineSiteDelegate(WmiContext wmiContext, uint resourceId = default);
        /// <summary>
        /// WMI static method <c>FindMachineSite</c>.
        /// </summary>
        public static FindMachineSiteDelegate FindMachineSite;
        
        /// <summary>
        /// WMI static method <c>CreateCCR</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="clientType">WMI Property <c>ClientType</c> of type <c>int</c>.</param>
        /// <param name="forced">WMI Property <c>Forced</c> of type <c>bool</c>.</param>
        /// <param name="forceReinstall">WMI Property <c>ForceReinstall</c> of type <c>bool</c>.</param>
        /// <param name="informationOnly">WMI Property <c>InformationOnly</c> of type <c>bool</c>.</param>
        /// <param name="pushEvenIfDc">WMI Property <c>PushEvenIfDC</c> of type <c>bool</c>.</param>
        /// <param name="pushOnlyAssignedClients">WMI Property <c>PushOnlyAssignedClients</c> of type <c>bool</c>.</param>
        /// <param name="pushSiteCode">WMI Property <c>PushSiteCode</c> of type <c>string</c>.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>uint</c>.</param>
        /// <param name="specifySiteCode">WMI Property <c>SpecifySiteCode</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CreateCcrDelegate(WmiContext wmiContext, int clientType = default, bool forced = default, bool forceReinstall = default, bool informationOnly = default, bool pushEvenIfDc = default, bool pushOnlyAssignedClients = default, string pushSiteCode = default, uint resourceId = default, bool specifySiteCode = default);
        /// <summary>
        /// WMI static method <c>CreateCCR</c>.
        /// </summary>
        public static CreateCcrDelegate CreateCcr;
        
        /// <summary>
        /// WMI static method <c>GenerateCCRByName</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="forced">WMI Property <c>Forced</c> of type <c>bool</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="pushSiteCode">WMI Property <c>PushSiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GenerateCcrByNameDelegate(WmiContext wmiContext, bool forced = default, string name = default, string pushSiteCode = default);
        /// <summary>
        /// WMI static method <c>GenerateCCRByName</c>.
        /// </summary>
        public static GenerateCcrByNameDelegate GenerateCcrByName;
        
        /// <summary>
        /// WMI static method <c>ApproveClients</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="approved">WMI Property <c>Approved</c> of type <c>bool</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ApproveClientsDelegate(WmiContext wmiContext, bool approved = default, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>ApproveClients</c>.
        /// </summary>
        public static ApproveClientsDelegate ApproveClients;
        
        /// <summary>
        /// WMI static method <c>BlockClients</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="blocked">WMI Property <c>Blocked</c> of type <c>bool</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint BlockClientsDelegate(WmiContext wmiContext, bool blocked = default, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>BlockClients</c>.
        /// </summary>
        public static BlockClientsDelegate BlockClients;
        
        /// <summary>
        /// WMI static method <c>ChangeOwnership</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="deviceOwner">WMI Property <c>DeviceOwner</c> of type <c>uint</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ChangeOwnershipDelegate(WmiContext wmiContext, uint deviceOwner = default, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>ChangeOwnership</c>.
        /// </summary>
        public static ChangeOwnershipDelegate ChangeOwnership;
        
        /// <summary>
        /// WMI static method <c>ClientEditions</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClientEditionsDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>ClientEditions</c>.
        /// </summary>
        public static ClientEditionsDelegate ClientEditions;
        
        /// <summary>
        /// WMI static method <c>ReassignClientsToSite</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="newSiteCode">WMI Property <c>NewSiteCode</c> of type <c>string</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ReassignClientsToSiteDelegate(WmiContext wmiContext, string newSiteCode = default, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>ReassignClientsToSite</c>.
        /// </summary>
        public static ReassignClientsToSiteDelegate ReassignClientsToSite;
        
        /// <summary>
        /// WMI static method <c>SetDeviceCategory</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="categoryId">WMI Property <c>CategoryID</c> of type <c>string</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetDeviceCategoryDelegate(WmiContext wmiContext, string categoryId = default, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>SetDeviceCategory</c>.
        /// </summary>
        public static SetDeviceCategoryDelegate SetDeviceCategory;
        
        /// <summary>
        /// WMI static method <c>ClearDeviceCategory</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClearDeviceCategoryDelegate(WmiContext wmiContext, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>ClearDeviceCategory</c>.
        /// </summary>
        public static ClearDeviceCategoryDelegate ClearDeviceCategory;
        
        /// <summary>
        /// WMI static method <c>ClearLastNBSAdvForMachines</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ClearLastNbsAdvForMachinesDelegate(WmiContext wmiContext, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>ClearLastNBSAdvForMachines</c>.
        /// </summary>
        public static ClearLastNbsAdvForMachinesDelegate ClearLastNbsAdvForMachines;
        
        /// <summary>
        /// WMI static method <c>SetMemberOrder</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint SetMemberOrderDelegate(WmiContext wmiContext, string collectionId = default, string resourceIDs = default);
        /// <summary>
        /// WMI static method <c>SetMemberOrder</c>.
        /// </summary>
        public static SetMemberOrderDelegate SetMemberOrder;
        
        /// <summary>
        /// WMI method <c>AMTOperateForCollection</c> describing delegate.
        /// <param name="opcode">WMI Property <c>opcode</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AmtOperateForCollectionDelegate(uint opcode = default);
        /// <summary>
        /// WMI method <c>AMTOperateForCollection</c>.
        /// </summary>
        public AmtOperateForCollectionDelegate AmtOperateForCollection;
        
        /// <summary>
        /// WMI static method <c>AMTOperateForMachines</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <param name="extData">WMI Property <c>extData</c> of type <c>uint</c>.</param>
        /// <param name="opcode">WMI Property <c>opcode</c> of type <c>uint</c>.</param>
        /// <param name="resourceIDs">WMI Property <c>ResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AmtOperateForMachinesDelegate(WmiContext wmiContext, string collectionId = default, uint extData = default, uint opcode = default, ICollection<uint> resourceIDs = default);
        /// <summary>
        /// WMI static method <c>AMTOperateForMachines</c>.
        /// </summary>
        public static AmtOperateForMachinesDelegate AmtOperateForMachines;
        
        /// <summary>
        /// WMI static method <c>GetServicePartners</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetServicePartnersDelegate(WmiContext wmiContext, string collectionId = default);
        /// <summary>
        /// WMI static method <c>GetServicePartners</c>.
        /// </summary>
        public static GetServicePartnersDelegate GetServicePartners;
        
        /// <summary>
        /// WMI static method <c>ModifyServicePartners</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionId">WMI Property <c>CollectionID</c> of type <c>string</c>.</param>
        /// <param name="servicePartners">WMI Property <c>ServicePartners</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ModifyServicePartnersDelegate(WmiContext wmiContext, string collectionId = default, uint servicePartners = default);
        /// <summary>
        /// WMI static method <c>ModifyServicePartners</c>.
        /// </summary>
        public static ModifyServicePartnersDelegate ModifyServicePartners;
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionRules
        /// </summary>
        public ICollection<SmsCollectionRule> CollectionRules { get; set; }
        /// <summary>
        /// WMI Property CollectionType
        /// </summary>
        public uint CollectionType { get; set; }
        /// <summary>
        /// WMI Property CollectionVariablesCount
        /// </summary>
        public int CollectionVariablesCount { get; set; }
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property CurrentStatus
        /// </summary>
        public uint CurrentStatus { get; set; }
        /// <summary>
        /// WMI Property HasProvisionedMember
        /// </summary>
        public bool HasProvisionedMember { get; set; }
        /// <summary>
        /// WMI Property IncludeExcludeCollectionsCount
        /// </summary>
        public int IncludeExcludeCollectionsCount { get; set; }
        /// <summary>
        /// WMI Property IsBuiltIn
        /// </summary>
        public bool IsBuiltIn { get; set; }
        /// <summary>
        /// WMI Property IsReferenceCollection
        /// </summary>
        public bool IsReferenceCollection { get; set; }
        /// <summary>
        /// WMI Property ISVData
        /// </summary>
        public ICollection<byte> IsvData { get; set; }
        /// <summary>
        /// WMI Property ISVDataSize
        /// </summary>
        public uint IsvDataSize { get; set; }
        /// <summary>
        /// WMI Property ISVString
        /// </summary>
        public string IsvString { get; set; }
        /// <summary>
        /// WMI Property LastChangeTime
        /// </summary>
        public DateTime LastChangeTime { get; set; }
        /// <summary>
        /// WMI Property LastMemberChangeTime
        /// </summary>
        public DateTime LastMemberChangeTime { get; set; }
        /// <summary>
        /// WMI Property LastRefreshTime
        /// </summary>
        public DateTime LastRefreshTime { get; set; }
        /// <summary>
        /// WMI Property LimitToCollectionID
        /// </summary>
        public string LimitToCollectionId { get; set; }
        /// <summary>
        /// WMI Property LimitToCollectionName
        /// </summary>
        public string LimitToCollectionName { get; set; }
        /// <summary>
        /// WMI Property LocalMemberCount
        /// </summary>
        public int LocalMemberCount { get; set; }
        /// <summary>
        /// WMI Property MemberClassName
        /// </summary>
        public string MemberClassName { get; set; }
        /// <summary>
        /// WMI Property MemberCount
        /// </summary>
        public int MemberCount { get; set; }
        /// <summary>
        /// WMI Property MonitoringFlags
        /// </summary>
        public uint MonitoringFlags { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ObjectPath
        /// </summary>
        public string ObjectPath { get; set; }
        /// <summary>
        /// WMI Property OwnedByThisSite
        /// </summary>
        public bool OwnedByThisSite { get; set; }
        /// <summary>
        /// WMI Property PowerConfigsCount
        /// </summary>
        public int PowerConfigsCount { get; set; }
        /// <summary>
        /// WMI Property RefreshSchedule
        /// </summary>
        public  ICollection<SmsScheduleToken> RefreshSchedule { get; set; }
        /// <summary>
        /// WMI Property RefreshType
        /// </summary>
        public uint RefreshType { get; set; }
        /// <summary>
        /// WMI Property ReplicateToSubSites
        /// </summary>
        public bool ReplicateToSubSites { get; set; }
        /// <summary>
        /// WMI Property ServiceWindowsCount
        /// </summary>
        public int ServiceWindowsCount { get; set; }
        /// <summary>
        /// WMI Property UseCluster
        /// </summary>
        public bool UseCluster { get; set; }
    }
}
