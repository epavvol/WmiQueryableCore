using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_ClientOperationStatus
    /// </summary>
    [WmiClass(Name = "SMS_G_System_ClientOperationStatus")]
    public class SmsGSystemClientOperationStatus
    {
        /// <summary>
        /// WMI Property IsCompleted
        /// </summary>
        public bool IsCompleted { get; set; }
        /// <summary>
        /// WMI Property IsFailed
        /// </summary>
        public bool IsFailed { get; set; }
        /// <summary>
        /// WMI Property IsOffline
        /// </summary>
        public bool IsOffline { get; set; }
        /// <summary>
        /// WMI Property IsUnknown
        /// </summary>
        public bool IsUnknown { get; set; }
        /// <summary>
        /// WMI Property OperationID
        /// </summary>
        public uint OperationId { get; set; }
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
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
