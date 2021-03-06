using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CMPivotTask
    /// </summary>
    [WmiClass(Name = "SMS_CMPivotTask")]
    public class SmsCmPivotTask
    {
        /// <summary>
        /// WMI Property ClientNotificationMessage
        /// </summary>
        public string ClientNotificationMessage { get; set; }
        /// <summary>
        /// WMI Property ClientOperationId
        /// </summary>
        public int ClientOperationId { get; set; }
        /// <summary>
        /// WMI Property CollectionId
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CompletedClients
        /// </summary>
        public int CompletedClients { get; set; }
        /// <summary>
        /// WMI Property FailedClients
        /// </summary>
        public int FailedClients { get; set; }
        /// <summary>
        /// WMI Property Feature
        /// </summary>
        public int Feature { get; set; }
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
        /// WMI Property OverallScriptExecutionState
        /// </summary>
        public int OverallScriptExecutionState { get; set; }
        /// <summary>
        /// WMI Property ReturnCodeCount
        /// </summary>
        public int ReturnCodeCount { get; set; }
        /// <summary>
        /// WMI Property ScriptGuid
        /// </summary>
        public string ScriptGuid { get; set; }
        /// <summary>
        /// WMI Property ScriptName
        /// </summary>
        public string ScriptName { get; set; }
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
