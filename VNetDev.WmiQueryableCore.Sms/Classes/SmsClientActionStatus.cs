using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientActionStatus
    /// </summary>
    [WmiClass(Name = "SMS_ClientActionStatus")]
    public class SmsClientActionStatus
    {
        /// <summary>
        /// WMI Property ActionID
        /// </summary>
        public uint ActionId { get; set; }
        /// <summary>
        /// WMI Property ActionState
        /// </summary>
        public uint ActionState { get; set; }
        /// <summary>
        /// WMI Property ActionType
        /// </summary>
        public uint ActionType { get; set; }
        /// <summary>
        /// WMI Property ActionUniqueID
        /// </summary>
        public string ActionUniqueId { get; set; }
        /// <summary>
        /// WMI Property CompletedClients
        /// </summary>
        public uint CompletedClients { get; set; }
        /// <summary>
        /// WMI Property FailedClients
        /// </summary>
        public uint FailedClients { get; set; }
        /// <summary>
        /// WMI Property OfflineClients
        /// </summary>
        public uint OfflineClients { get; set; }
        /// <summary>
        /// WMI Property OperationID
        /// </summary>
        public uint OperationId { get; set; }
        /// <summary>
        /// WMI Property OperationUniqueID
        /// </summary>
        public string OperationUniqueId { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property TimeLastUpdated
        /// </summary>
        public DateTime TimeLastUpdated { get; set; }
        /// <summary>
        /// WMI Property TotalClients
        /// </summary>
        public uint TotalClients { get; set; }
        /// <summary>
        /// WMI Property UnknownClients
        /// </summary>
        public uint UnknownClients { get; set; }
    }
}
