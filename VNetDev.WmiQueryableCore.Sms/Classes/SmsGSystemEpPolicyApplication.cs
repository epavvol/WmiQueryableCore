using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_EPPolicyApplication
    /// </summary>
    [WmiClass(Name = "SMS_G_System_EPPolicyApplication")]
    public class SmsGSystemEpPolicyApplication
    {
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property Error
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property LastMessageTime
        /// </summary>
        public DateTime LastMessageTime { get; set; }
        /// <summary>
        /// WMI Property PolicyApplicationState
        /// </summary>
        public uint PolicyApplicationState { get; set; }
        /// <summary>
        /// WMI Property PolicyName
        /// </summary>
        public string PolicyName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
