using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CMPivotStatus
    /// </summary>
    [WmiClass(Name = "SMS_CMPivotStatus")]
    public class SmsCmPivotStatus
    {
        /// <summary>
        /// WMI static method <c>CMPivotQuery</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="maxResults">WMI Property <c>MaxResults</c> of type <c>uint</c>.</param>
        /// <param name="operationId">WMI Property <c>OperationID</c> of type <c>uint</c>.</param>
        /// <param name="query">WMI Property <c>Query</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CmPivotQueryDelegate(WmiContext wmiContext, uint maxResults = default, uint operationId = default, string query = default);
        /// <summary>
        /// WMI static method <c>CMPivotQuery</c>.
        /// </summary>
        public static CmPivotQueryDelegate CmPivotQuery;
        
        /// <summary>
        /// WMI static method <c>DeleteResults</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskId">WMI Property <c>TaskId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteResultsDelegate(WmiContext wmiContext, string taskId = default);
        /// <summary>
        /// WMI static method <c>DeleteResults</c>.
        /// </summary>
        public static DeleteResultsDelegate DeleteResults;
        
        /// <summary>
        /// WMI static method <c>InitiateDeleteResultsFromCAS</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="taskId">WMI Property <c>TaskId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InitiateDeleteResultsFromCasDelegate(WmiContext wmiContext, string taskId = default);
        /// <summary>
        /// WMI static method <c>InitiateDeleteResultsFromCAS</c>.
        /// </summary>
        public static InitiateDeleteResultsFromCasDelegate InitiateDeleteResultsFromCas;
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
        /// WMI Property DeviceName
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// WMI Property ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }
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
        /// WMI Property OutputLength
        /// </summary>
        public int OutputLength { get; set; }
        /// <summary>
        /// WMI Property ResourceId
        /// </summary>
        public int ResourceId { get; set; }
        /// <summary>
        /// WMI Property ReturnCode
        /// </summary>
        public int ReturnCode { get; set; }
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
