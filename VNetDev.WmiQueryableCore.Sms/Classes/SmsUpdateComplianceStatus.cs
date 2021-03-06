using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UpdateComplianceStatus
    /// </summary>
    [WmiClass(Name = "SMS_UpdateComplianceStatus")]
    public class SmsUpdateComplianceStatus
    {
        /// <summary>
        /// WMI Property ArticleID
        /// </summary>
        public string ArticleId { get; set; }
        /// <summary>
        /// WMI Property BulletinID
        /// </summary>
        public string BulletinId { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property EnforcementSource
        /// </summary>
        public uint EnforcementSource { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageID
        /// </summary>
        public uint LastEnforcementMessageId { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageName
        /// </summary>
        public string LastEnforcementMessageName { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementMessageTime
        /// </summary>
        public DateTime LastEnforcementMessageTime { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementStatusMsgID
        /// </summary>
        public uint LastEnforcementStatusMsgId { get; set; }
        /// <summary>
        /// WMI Property LastStatusChangeTime
        /// </summary>
        public DateTime LastStatusChangeTime { get; set; }
        /// <summary>
        /// WMI Property LastStatusCheckTime
        /// </summary>
        public DateTime LastStatusCheckTime { get; set; }
        /// <summary>
        /// WMI Property LocalizedDescription
        /// </summary>
        public string LocalizedDescription { get; set; }
        /// <summary>
        /// WMI Property LocalizedDisplayName
        /// </summary>
        public string LocalizedDisplayName { get; set; }
        /// <summary>
        /// WMI Property LocalizedInformativeURL
        /// </summary>
        public string LocalizedInformativeUrl { get; set; }
        /// <summary>
        /// WMI Property MachineID
        /// </summary>
        public uint MachineId { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property UpdateLocales
        /// </summary>
        public string UpdateLocales { get; set; }
    }
}
