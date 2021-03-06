using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ObjectLockRequest
    /// </summary>
    [WmiClass(Name = "SMS_ObjectLockRequest")]
    public class SmsObjectLockRequest
    {
        /// <summary>
        /// WMI Property AssignedMachine
        /// </summary>
        public string AssignedMachine { get; set; }
        /// <summary>
        /// WMI Property AssignedObjectLockContext
        /// </summary>
        public string AssignedObjectLockContext { get; set; }
        /// <summary>
        /// WMI Property AssignedSiteCode
        /// </summary>
        public string AssignedSiteCode { get; set; }
        /// <summary>
        /// WMI Property AssignedTimeUTC
        /// </summary>
        public DateTime AssignedTimeUtc { get; set; }
        /// <summary>
        /// WMI Property AssignedUser
        /// </summary>
        public string AssignedUser { get; set; }
        /// <summary>
        /// WMI Property LockState
        /// </summary>
        public uint LockState { get; set; }
        /// <summary>
        /// WMI Property ObjectRelPath
        /// </summary>
        public string ObjectRelPath { get; set; }
        /// <summary>
        /// WMI Property RequestID
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// WMI Property RequestState
        /// </summary>
        public uint RequestState { get; set; }
    }
}
