using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_SYSTEM_AmPolicyStatus
    /// </summary>
    [WmiClass(Name = "SMS_G_SYSTEM_AmPolicyStatus")]
    public class SmsGSystemAmPolicyStatus
    {
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property Error
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PolicyType
        /// </summary>
        public uint PolicyType { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
    }
}
