using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppRequirementsData
    /// </summary>
    [WmiClass(Name = "SMS_AppRequirementsData")]
    public class SmsAppRequirementsData
    {
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property DTCI
        /// </summary>
        public uint Dtci { get; set; }
        /// <summary>
        /// WMI Property DTResultID
        /// </summary>
        public ulong DtResultId { get; set; }
        /// <summary>
        /// WMI Property InstanceGroup
        /// </summary>
        public uint InstanceGroup { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property RequirementName
        /// </summary>
        public string RequirementName { get; set; }
        /// <summary>
        /// WMI Property RuleID
        /// </summary>
        public uint RuleId { get; set; }
        /// <summary>
        /// WMI Property SettingName
        /// </summary>
        public string SettingName { get; set; }
        /// <summary>
        /// WMI Property SettingValue
        /// </summary>
        public string SettingValue { get; set; }
        /// <summary>
        /// WMI Property UniqueRequirementName
        /// </summary>
        public string UniqueRequirementName { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
