using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AppConflictsData
    /// </summary>
    [WmiClass(Name = "SMS_AppConflictsData")]
    public class SmsAppConflictsData
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
        /// WMI Property ConflictsWith
        /// </summary>
        public string ConflictsWith { get; set; }
        /// <summary>
        /// WMI Property DTCI
        /// </summary>
        public uint Dtci { get; set; }
        /// <summary>
        /// WMI Property DTResultID
        /// </summary>
        public ulong DtResultId { get; set; }
        /// <summary>
        /// WMI Property MachineName
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// WMI Property RequiredBy
        /// </summary>
        public string RequiredBy { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
