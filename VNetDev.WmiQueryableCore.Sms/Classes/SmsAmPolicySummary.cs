using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AmPolicySummary
    /// </summary>
    [WmiClass(Name = "SMS_AmPolicySummary")]
    public class SmsAmPolicySummary
    {
        /// <summary>
        /// WMI Property AppliedCount
        /// </summary>
        public uint AppliedCount { get; set; }
        /// <summary>
        /// WMI Property AssignmentTime
        /// </summary>
        public DateTime AssignmentTime { get; set; }
        /// <summary>
        /// WMI Property ClientSettingsID
        /// </summary>
        public uint ClientSettingsId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property FailureCount
        /// </summary>
        public uint FailureCount { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property LastClientUpdateTime
        /// </summary>
        public DateTime LastClientUpdateTime { get; set; }
        /// <summary>
        /// WMI Property NotAppliedCount
        /// </summary>
        public uint NotAppliedCount { get; set; }
        /// <summary>
        /// WMI Property TotalCount
        /// </summary>
        public uint TotalCount { get; set; }
        /// <summary>
        /// WMI Property UnknownCount
        /// </summary>
        public uint UnknownCount { get; set; }
    }
}
