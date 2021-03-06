using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_ClientActionStatus
    /// </summary>
    [WmiClass(Name = "SMS_G_System_ClientActionStatus")]
    public class SmsGSystemClientActionStatus
    {
        /// <summary>
        /// WMI Property ActionID
        /// </summary>
        public uint ActionId { get; set; }
        /// <summary>
        /// WMI Property ActionResult
        /// </summary>
        public uint ActionResult { get; set; }
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
        /// WMI Property Error
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property OperationID
        /// </summary>
        public uint OperationId { get; set; }
        /// <summary>
        /// WMI Property OperationUniqueID
        /// </summary>
        public string OperationUniqueId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property TimeLastUpdated
        /// </summary>
        public DateTime TimeLastUpdated { get; set; }
    }
}
