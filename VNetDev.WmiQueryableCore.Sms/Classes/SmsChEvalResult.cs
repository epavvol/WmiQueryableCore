using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CH_EvalResult
    /// </summary>
    [WmiClass(Name = "SMS_CH_EvalResult")]
    public class SmsChEvalResult
    {
        /// <summary>
        /// WMI Property EvalTime
        /// </summary>
        public DateTime EvalTime { get; set; }
        /// <summary>
        /// WMI Property HealthCheckDescription
        /// </summary>
        public string HealthCheckDescription { get; set; }
        /// <summary>
        /// WMI Property HealthCheckGUID
        /// </summary>
        public string HealthCheckGuid { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property Result
        /// </summary>
        public uint Result { get; set; }
        /// <summary>
        /// WMI Property ResultCode
        /// </summary>
        public uint ResultCode { get; set; }
        /// <summary>
        /// WMI Property ResultDetail
        /// </summary>
        public string ResultDetail { get; set; }
        /// <summary>
        /// WMI Property ResultType
        /// </summary>
        public uint ResultType { get; set; }
    }
}
