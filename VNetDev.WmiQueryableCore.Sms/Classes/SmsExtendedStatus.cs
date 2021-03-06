using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ExtendedStatus
    /// </summary>
    [WmiClass(Name = "SMS_ExtendedStatus")]
    public class SmsExtendedStatus
    {
        /// <summary>
        /// WMI Property CauseInfo
        /// </summary>
        public string CauseInfo { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property ErrorCode
        /// </summary>
        public uint ErrorCode { get; set; }
        /// <summary>
        /// WMI Property File
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// WMI Property Line
        /// </summary>
        public uint Line { get; set; }
        /// <summary>
        /// WMI Property ObjectInfo
        /// </summary>
        public string ObjectInfo { get; set; }
        /// <summary>
        /// WMI Property Operation
        /// </summary>
        public string Operation { get; set; }
        /// <summary>
        /// WMI Property ParameterInfo
        /// </summary>
        public string ParameterInfo { get; set; }
        /// <summary>
        /// WMI Property ProviderName
        /// </summary>
        public string ProviderName { get; set; }
        /// <summary>
        /// WMI Property SQLMessage
        /// </summary>
        public string SqlMessage { get; set; }
        /// <summary>
        /// WMI Property SQLSeverity
        /// </summary>
        public uint SqlSeverity { get; set; }
        /// <summary>
        /// WMI Property SQLStatus
        /// </summary>
        public uint SqlStatus { get; set; }
        /// <summary>
        /// WMI Property StatusCode
        /// </summary>
        public uint StatusCode { get; set; }
    }
}
