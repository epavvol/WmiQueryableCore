using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ActionAccountResult
    /// </summary>
    [WmiClass(Name = "SMS_ActionAccountResult")]
    public class SmsActionAccountResult
    {
        /// <summary>
        /// WMI Property ActionData
        /// </summary>
        public string ActionData { get; set; }
        /// <summary>
        /// WMI Property ActionID
        /// </summary>
        public int ActionId { get; set; }
        /// <summary>
        /// WMI Property ActionResult
        /// </summary>
        public int ActionResult { get; set; }
        /// <summary>
        /// WMI Property ActionResultDetail
        /// </summary>
        public string ActionResultDetail { get; set; }
        /// <summary>
        /// WMI Property ActionResultID
        /// </summary>
        public int ActionResultId { get; set; }
        /// <summary>
        /// WMI Property EndTime
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// WMI Property StartTime
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
