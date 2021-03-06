using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_UpdateState_Combined
    /// </summary>
    [WmiClass(Name = "SMS_UpdateState_Combined")]
    public class SmsUpdateStateCombined
    {
        /// <summary>
        /// WMI Property CI_ID
        /// </summary>
        [WmiProperty(Name = "CI_ID")]
        public int CiId { get; set; }
        /// <summary>
        /// WMI Property EnforcementSource
        /// </summary>
        public string EnforcementSource { get; set; }
        /// <summary>
        /// WMI Property LastEnforcementStatusMsgID
        /// </summary>
        public string LastEnforcementStatusMsgId { get; set; }
        /// <summary>
        /// WMI Property LastErrorCode
        /// </summary>
        public string LastErrorCode { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public string ResourceId { get; set; }
        /// <summary>
        /// WMI Property StateID
        /// </summary>
        public int StateId { get; set; }
        /// <summary>
        /// WMI Property StateTime
        /// </summary>
        public string StateTime { get; set; }
        /// <summary>
        /// WMI Property StateType
        /// </summary>
        public int StateType { get; set; }
    }
}
