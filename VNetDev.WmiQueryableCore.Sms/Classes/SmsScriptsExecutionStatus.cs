using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ScriptsExecutionStatus
    /// </summary>
    [WmiClass(Name = "SMS_ScriptsExecutionStatus")]
    public class SmsScriptsExecutionStatus
    {
        /// <summary>
        /// WMI Property ClientOperationId
        /// </summary>
        public int ClientOperationId { get; set; }
        /// <summary>
        /// WMI Property CollectionId
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property CompletedClients
        /// </summary>
        public int CompletedClients { get; set; }
        /// <summary>
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property FailedClients
        /// </summary>
        public int FailedClients { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property NotApplicableClients
        /// </summary>
        public int NotApplicableClients { get; set; }
        /// <summary>
        /// WMI Property OfflineClients
        /// </summary>
        public int OfflineClients { get; set; }
        /// <summary>
        /// WMI Property ResourceId
        /// </summary>
        public int ResourceId { get; set; }
        /// <summary>
        /// WMI Property ScriptExecutionState
        /// </summary>
        public int ScriptExecutionState { get; set; }
        /// <summary>
        /// WMI Property ScriptExitCode
        /// </summary>
        public int ScriptExitCode { get; set; }
        /// <summary>
        /// WMI Property ScriptGuid
        /// </summary>
        public string ScriptGuid { get; set; }
        /// <summary>
        /// WMI Property ScriptLastModifiedDate
        /// </summary>
        public DateTime ScriptLastModifiedDate { get; set; }
        /// <summary>
        /// WMI Property ScriptName
        /// </summary>
        public string ScriptName { get; set; }
        /// <summary>
        /// WMI Property ScriptOutput
        /// </summary>
        public string ScriptOutput { get; set; }
        /// <summary>
        /// WMI Property ScriptOutputHash
        /// </summary>
        public string ScriptOutputHash { get; set; }
        /// <summary>
        /// WMI Property ScriptVersion
        /// </summary>
        public string ScriptVersion { get; set; }
        /// <summary>
        /// WMI Property SiteNumber
        /// </summary>
        public int SiteNumber { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// WMI Property TaskID
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// WMI Property TotalClients
        /// </summary>
        public int TotalClients { get; set; }
        /// <summary>
        /// WMI Property UnknownClients
        /// </summary>
        public int UnknownClients { get; set; }
    }
}
