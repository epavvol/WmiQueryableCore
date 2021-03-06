using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UpdateDeploymentSummary
    /// </summary>
    [WmiClass(Name = "SMS_UpdateDeploymentSummary")]
    public class SmsUpdateDeploymentSummary
    {
        /// <summary>
        /// WMI Property AssignmentEnabled
        /// </summary>
        public bool AssignmentEnabled { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property AssignmentName
        /// </summary>
        public string AssignmentName { get; set; }
        /// <summary>
        /// WMI Property AssignmentUniqueID
        /// </summary>
        public string AssignmentUniqueId { get; set; }
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public uint CiId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property IncludeSubCollections
        /// </summary>
        public bool IncludeSubCollections { get; set; }
        /// <summary>
        /// WMI Property NumFailed
        /// </summary>
        public uint NumFailed { get; set; }
        /// <summary>
        /// WMI Property NumInstalled
        /// </summary>
        public uint NumInstalled { get; set; }
        /// <summary>
        /// WMI Property NumMissing
        /// </summary>
        public uint NumMissing { get; set; }
        /// <summary>
        /// WMI Property NumNotApplicable
        /// </summary>
        public uint NumNotApplicable { get; set; }
        /// <summary>
        /// WMI Property NumPresent
        /// </summary>
        public uint NumPresent { get; set; }
        /// <summary>
        /// WMI Property NumTotal
        /// </summary>
        public uint NumTotal { get; set; }
        /// <summary>
        /// WMI Property NumUnknown
        /// </summary>
        public uint NumUnknown { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
