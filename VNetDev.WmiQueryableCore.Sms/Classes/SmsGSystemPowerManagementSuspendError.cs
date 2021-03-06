using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_POWER_MANAGEMENT_SUSPEND_ERROR
    /// </summary>
    [WmiClass(Name = "SMS_G_System_POWER_MANAGEMENT_SUSPEND_ERROR")]
    public class SmsGSystemPowerManagementSuspendError
    {
        /// <summary>
        /// WMI Property AdditionalCode
        /// </summary>
        public uint AdditionalCode { get; set; }
        /// <summary>
        /// WMI Property AdditionalInfo
        /// </summary>
        public string AdditionalInfo { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Requester
        /// </summary>
        public string Requester { get; set; }
        /// <summary>
        /// WMI Property RequesterInfo
        /// </summary>
        public string RequesterInfo { get; set; }
        /// <summary>
        /// WMI Property RequesterType
        /// </summary>
        public string RequesterType { get; set; }
        /// <summary>
        /// WMI Property RequestType
        /// </summary>
        public string RequestType { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property Time
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UnknownRequester
        /// </summary>
        public uint UnknownRequester { get; set; }
    }
}
