using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientOperation
    /// </summary>
    [WmiClass(Name = "SMS_ClientOperation")]
    public class SmsClientOperation
    {
        /// <summary>
        /// WMI static method <c>InitiateClientOperation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="randomizationWindow">WMI Property <c>RandomizationWindow</c> of type <c>uint</c>.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="targetResourceIDs">WMI Property <c>TargetResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InitiateClientOperationDelegate(WmiContext wmiContext, uint randomizationWindow = default, string targetCollectionId = default, ICollection<uint> targetResourceIDs = default, uint type = default);
        /// <summary>
        /// WMI static method <c>InitiateClientOperation</c>.
        /// </summary>
        public static InitiateClientOperationDelegate InitiateClientOperation;
        
        /// <summary>
        /// WMI static method <c>InitiateClientOperationEx</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="param">WMI Property <c>Param</c> of type <c>string</c>.</param>
        /// <param name="randomizationWindow">WMI Property <c>RandomizationWindow</c> of type <c>uint</c>.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="targetResourceIDs">WMI Property <c>TargetResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InitiateClientOperationExDelegate(WmiContext wmiContext, string param = default, uint randomizationWindow = default, string targetCollectionId = default, ICollection<uint> targetResourceIDs = default, uint type = default);
        /// <summary>
        /// WMI static method <c>InitiateClientOperationEx</c>.
        /// </summary>
        public static InitiateClientOperationExDelegate InitiateClientOperationEx;
        
        /// <summary>
        /// WMI static method <c>RestoreQuarantinedItem</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="includeDependencies">WMI Property <c>IncludeDependencies</c> of type <c>bool</c>.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="threatId">WMI Property <c>ThreatID</c> of type <c>ulong</c>.</param>
        /// <param name="threatName">WMI Property <c>ThreatName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint RestoreQuarantinedItemDelegate(WmiContext wmiContext, bool includeDependencies = default, string targetCollectionId = default, ulong threatId = default, string threatName = default);
        /// <summary>
        /// WMI static method <c>RestoreQuarantinedItem</c>.
        /// </summary>
        public static RestoreQuarantinedItemDelegate RestoreQuarantinedItem;
        
        /// <summary>
        /// WMI static method <c>AllowThreat</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="allowSettingsUniqueId">WMI Property <c>AllowSettingsUniqueID</c> of type <c>string</c>.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="threatId">WMI Property <c>ThreatID</c> of type <c>ulong</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint AllowThreatDelegate(WmiContext wmiContext, string allowSettingsUniqueId = default, string targetCollectionId = default, ulong threatId = default);
        /// <summary>
        /// WMI static method <c>AllowThreat</c>.
        /// </summary>
        public static AllowThreatDelegate AllowThreat;
        
        /// <summary>
        /// WMI static method <c>ExcludeScanPaths</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="excludedPaths">WMI Property <c>ExcludedPaths</c> of type <c>ICollection{string}</c>.</param>
        /// <param name="exclusionSettingsUniqueId">WMI Property <c>ExclusionSettingsUniqueID</c> of type <c>string</c>.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="threatId">WMI Property <c>ThreatID</c> of type <c>ulong</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ExcludeScanPathsDelegate(WmiContext wmiContext, ICollection<string> excludedPaths = default, string exclusionSettingsUniqueId = default, string targetCollectionId = default, ulong threatId = default);
        /// <summary>
        /// WMI static method <c>ExcludeScanPaths</c>.
        /// </summary>
        public static ExcludeScanPathsDelegate ExcludeScanPaths;
        
        /// <summary>
        /// WMI static method <c>CancelClientOperation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="operationId">WMI Property <c>OperationID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CancelClientOperationDelegate(WmiContext wmiContext, uint operationId = default);
        /// <summary>
        /// WMI static method <c>CancelClientOperation</c>.
        /// </summary>
        public static CancelClientOperationDelegate CancelClientOperation;
        
        /// <summary>
        /// WMI static method <c>DeleteClientOperation</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="operationId">WMI Property <c>OperationID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteClientOperationDelegate(WmiContext wmiContext, uint operationId = default);
        /// <summary>
        /// WMI static method <c>DeleteClientOperation</c>.
        /// </summary>
        public static DeleteClientOperationDelegate DeleteClientOperation;
        
        /// <summary>
        /// WMI static method <c>IsClientOperationAllowed</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="targetCollectionId">WMI Property <c>TargetCollectionID</c> of type <c>string</c>.</param>
        /// <param name="targetResourceIDs">WMI Property <c>TargetResourceIDs</c> of type <c>ICollection{uint}</c>.</param>
        /// <param name="type">WMI Property <c>Type</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint IsClientOperationAllowedDelegate(WmiContext wmiContext, string targetCollectionId = default, ICollection<uint> targetResourceIDs = default, uint type = default);
        /// <summary>
        /// WMI static method <c>IsClientOperationAllowed</c>.
        /// </summary>
        public static IsClientOperationAllowedDelegate IsClientOperationAllowed;
        
        /// <summary>
        /// WMI static method <c>IsClientOperationUpdateAllowed</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="operationId">WMI Property <c>OperationID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint IsClientOperationUpdateAllowedDelegate(WmiContext wmiContext, uint operationId = default);
        /// <summary>
        /// WMI static method <c>IsClientOperationUpdateAllowed</c>.
        /// </summary>
        public static IsClientOperationUpdateAllowedDelegate IsClientOperationUpdateAllowed;
        /// <summary>
        /// WMI Property Actions
        /// </summary>
        public ICollection<object> Actions { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property DependentClientOperations
        /// </summary>
        public ICollection<uint> DependentClientOperations { get; set; }
        /// <summary>
        /// WMI Property Filter
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// WMI Property FilterType
        /// </summary>
        public uint FilterType { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsActionsDependent
        /// </summary>
        public bool IsActionsDependent { get; set; }
        /// <summary>
        /// WMI Property PrimaryActionTargetObjectID
        /// </summary>
        public string PrimaryActionTargetObjectId { get; set; }
        /// <summary>
        /// WMI Property PrimaryActionTargetObjectName
        /// </summary>
        public string PrimaryActionTargetObjectName { get; set; }
        /// <summary>
        /// WMI Property PrimaryActionTargetObjectType
        /// </summary>
        public uint PrimaryActionTargetObjectType { get; set; }
        /// <summary>
        /// WMI Property PrimaryActionType
        /// </summary>
        public uint PrimaryActionType { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property RequestedTime
        /// </summary>
        public DateTime RequestedTime { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property TargetCollectionName
        /// </summary>
        public string TargetCollectionName { get; set; }
        /// <summary>
        /// WMI Property TargetResourceIDs
        /// </summary>
        public ICollection<uint> TargetResourceIDs { get; set; }
        /// <summary>
        /// WMI Property TargetType
        /// </summary>
        public uint TargetType { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
