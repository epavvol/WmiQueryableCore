using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientOperationStatus
    /// </summary>
    [WmiClass(Name = "SMS_ClientOperationStatus")]
    public class SmsClientOperationStatus
    {
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CompletedClients
        /// </summary>
        public uint CompletedClients { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property FailedClients
        /// </summary>
        public uint FailedClients { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsExpired
        /// </summary>
        public uint IsExpired { get; set; }
        /// <summary>
        /// WMI Property LastSummaryTime
        /// </summary>
        public DateTime LastSummaryTime { get; set; }
        /// <summary>
        /// WMI Property OfflineClients
        /// </summary>
        public uint OfflineClients { get; set; }
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
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property TargetCollectionName
        /// </summary>
        public string TargetCollectionName { get; set; }
        /// <summary>
        /// WMI Property TimeLastUpdated
        /// </summary>
        public DateTime TimeLastUpdated { get; set; }
        /// <summary>
        /// WMI Property TotalClients
        /// </summary>
        public uint TotalClients { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// WMI Property UnknownClients
        /// </summary>
        public uint UnknownClients { get; set; }
    }
}
