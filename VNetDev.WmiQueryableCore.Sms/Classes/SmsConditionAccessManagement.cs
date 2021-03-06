using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ConditionAccessManagement
    /// </summary>
    [WmiClass(Name = "SMS_ConditionAccessManagement")]
    public class SmsConditionAccessManagement
    {
        /// <summary>
        /// WMI Property ConditionalAccessType
        /// </summary>
        public int ConditionalAccessType { get; set; }
        /// <summary>
        /// WMI Property ExclusionGroupsID
        /// </summary>
        public string ExclusionGroupsId { get; set; }
        /// <summary>
        /// WMI Property InclusionGroupsID
        /// </summary>
        public string InclusionGroupsId { get; set; }
        /// <summary>
        /// WMI Property IntuneDomainName
        /// </summary>
        public string IntuneDomainName { get; set; }
        /// <summary>
        /// WMI Property NotificationText
        /// </summary>
        public string NotificationText { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public int ResourceType { get; set; }
    }
}
