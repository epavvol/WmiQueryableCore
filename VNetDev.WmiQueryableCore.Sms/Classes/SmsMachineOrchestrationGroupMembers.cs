using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MachineOrchestrationGroupMembers
    /// </summary>
    [WmiClass(Name = "SMS_MachineOrchestrationGroupMembers")]
    public class SmsMachineOrchestrationGroupMembers
    {
        /// <summary>
        /// WMI static method <c>ResetMOGMember</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ResetMogMemberDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>ResetMOGMember</c>.
        /// </summary>
        public static ResetMogMemberDelegate ResetMogMember;
        /// <summary>
        /// WMI Property ClientType
        /// </summary>
        public uint ClientType { get; set; }
        /// <summary>
        /// WMI Property CNIsOnline
        /// </summary>
        public bool CnIsOnline { get; set; }
        /// <summary>
        /// WMI Property CurrentLogonUser
        /// </summary>
        public string CurrentLogonUser { get; set; }
        /// <summary>
        /// WMI Property CurrentState
        /// </summary>
        public int CurrentState { get; set; }
        /// <summary>
        /// WMI Property IsActive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// WMI Property LastStateReportedTime
        /// </summary>
        public DateTime LastStateReportedTime { get; set; }
        /// <summary>
        /// WMI Property LockAcquiredTime
        /// </summary>
        public DateTime LockAcquiredTime { get; set; }
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
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PrimaryUser
        /// </summary>
        public string PrimaryUser { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public int ResourceId { get; set; }
        /// <summary>
        /// WMI Property SequenceNumber
        /// </summary>
        public int SequenceNumber { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property StateCode
        /// </summary>
        public int StateCode { get; set; }
    }
}
