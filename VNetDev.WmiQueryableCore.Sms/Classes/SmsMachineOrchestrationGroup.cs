using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MachineOrchestrationGroup
    /// </summary>
    [WmiClass(Name = "SMS_MachineOrchestrationGroup")]
    public class SmsMachineOrchestrationGroup
    {
        /// <summary>
        /// WMI static method <c>InsertUpdateMachineOrchestrationGroup</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="description">WMI Property <c>Description</c> of type <c>string</c>.</param>
        /// <param name="flag">WMI Property <c>Flag</c> of type <c>int</c>.</param>
        /// <param name="maxLockTimeOut">WMI Property <c>MaxLockTimeOut</c> of type <c>int</c>.</param>
        /// <param name="mogUniqueId">WMI Property <c>MOG_UniqueID</c> of type <c>string</c>.</param>
        /// <param name="mogMembers">WMI Property <c>MOGMembers</c> of type <c>ICollection{int}</c>.</param>
        /// <param name="name">WMI Property <c>Name</c> of type <c>string</c>.</param>
        /// <param name="orchestrationTimeOut">WMI Property <c>OrchestrationTimeOut</c> of type <c>int</c>.</param>
        /// <param name="orchestrationType">WMI Property <c>OrchestrationType</c> of type <c>int</c>.</param>
        /// <param name="orchestrationValue">WMI Property <c>OrchestrationValue</c> of type <c>int</c>.</param>
        /// <param name="postScript">WMI Property <c>PostScript</c> of type <c>string</c>.</param>
        /// <param name="postScriptTimeout">WMI Property <c>PostScriptTimeout</c> of type <c>int</c>.</param>
        /// <param name="preScript">WMI Property <c>PreScript</c> of type <c>string</c>.</param>
        /// <param name="preScriptTimeout">WMI Property <c>PreScriptTimeout</c> of type <c>int</c>.</param>
        /// <param name="siteCode">WMI Property <c>SiteCode</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint InsertUpdateMachineOrchestrationGroupDelegate(WmiContext wmiContext, string description = default, int flag = default, int maxLockTimeOut = default, string mogUniqueId = default, ICollection<int> mogMembers = default, string name = default, int orchestrationTimeOut = default, int orchestrationType = default, int orchestrationValue = default, string postScript = default, int postScriptTimeout = default, string preScript = default, int preScriptTimeout = default, string siteCode = default);
        /// <summary>
        /// WMI static method <c>InsertUpdateMachineOrchestrationGroup</c>.
        /// </summary>
        public static InsertUpdateMachineOrchestrationGroupDelegate InsertUpdateMachineOrchestrationGroup;
        
        /// <summary>
        /// WMI static method <c>StartOrchestrationGroup</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint StartOrchestrationGroupDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>StartOrchestrationGroup</c>.
        /// </summary>
        public static StartOrchestrationGroupDelegate StartOrchestrationGroup;
        
        /// <summary>
        /// WMI static method <c>ResetMOGMember</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="resourceId">WMI Property <c>ResourceID</c> of type <c>int</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ResetMogMemberDelegate(WmiContext wmiContext, int resourceId = default);
        /// <summary>
        /// WMI static method <c>ResetMOGMember</c>.
        /// </summary>
        public static ResetMogMemberDelegate ResetMogMember;
        /// <summary>
        /// WMI Property CurrentSequenceNumber
        /// </summary>
        public int CurrentSequenceNumber { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Failed
        /// </summary>
        public int Failed { get; set; }
        /// <summary>
        /// WMI Property Flag
        /// </summary>
        public int Flag { get; set; }
        /// <summary>
        /// WMI Property LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// WMI Property LastModifiedTime
        /// </summary>
        public DateTime LastModifiedTime { get; set; }
        /// <summary>
        /// WMI Property MaxLockTimeOut
        /// </summary>
        public int MaxLockTimeOut { get; set; }
        /// <summary>
        /// WMI Property MOG_UniqueID
        /// </summary>
        [WmiProperty(Name = "MOG_UniqueID")]
        public string MogUniqueId { get; set; }
        /// <summary>
        /// WMI Property MOGID
        /// </summary>
        public int Mogid { get; set; }
        /// <summary>
        /// WMI Property MOGMembers
        /// </summary>
        public ICollection<int> MogMembers { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OrchestrationStartTime
        /// </summary>
        public DateTime OrchestrationStartTime { get; set; }
        /// <summary>
        /// WMI Property OrchestrationState
        /// </summary>
        public int OrchestrationState { get; set; }
        /// <summary>
        /// WMI Property OrchestrationTimeOut
        /// </summary>
        public int OrchestrationTimeOut { get; set; }
        /// <summary>
        /// WMI Property OrchestrationType
        /// </summary>
        public int OrchestrationType { get; set; }
        /// <summary>
        /// WMI Property OrchestrationValue
        /// </summary>
        public int OrchestrationValue { get; set; }
        /// <summary>
        /// WMI Property PostScript
        /// </summary>
        public string PostScript { get; set; }
        /// <summary>
        /// WMI Property PostScriptTimeout
        /// </summary>
        public int PostScriptTimeout { get; set; }
        /// <summary>
        /// WMI Property PreScript
        /// </summary>
        public string PreScript { get; set; }
        /// <summary>
        /// WMI Property PreScriptTimeout
        /// </summary>
        public int PreScriptTimeout { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Total
        /// </summary>
        public int Total { get; set; }
    }
}
