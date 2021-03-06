using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ClientAdvertisementStatus
    /// </summary>
    [WmiClass(Name = "SMS_ClientAdvertisementStatus")]
    public class SmsClientAdvertisementStatus
    {
        /// <summary>
        /// WMI Property AdvertisementID
        /// </summary>
        public string AdvertisementId { get; set; }
        /// <summary>
        /// WMI Property LastAcceptanceMessageID
        /// </summary>
        public uint LastAcceptanceMessageId { get; set; }
        /// <summary>
        /// WMI Property LastAcceptanceMessageIDName
        /// </summary>
        public string LastAcceptanceMessageIdName { get; set; }
        /// <summary>
        /// WMI Property LastAcceptanceMessageIDSeverity
        /// </summary>
        public uint LastAcceptanceMessageIdSeverity { get; set; }
        /// <summary>
        /// WMI Property LastAcceptanceState
        /// </summary>
        public uint LastAcceptanceState { get; set; }
        /// <summary>
        /// WMI Property LastAcceptanceStateName
        /// </summary>
        public string LastAcceptanceStateName { get; set; }
        /// <summary>
        /// WMI Property LastAcceptanceStatusTime
        /// </summary>
        public DateTime LastAcceptanceStatusTime { get; set; }
        /// <summary>
        /// WMI Property LastExecutionContext
        /// </summary>
        public string LastExecutionContext { get; set; }
        /// <summary>
        /// WMI Property LastExecutionResult
        /// </summary>
        public string LastExecutionResult { get; set; }
        /// <summary>
        /// WMI Property LastState
        /// </summary>
        public uint LastState { get; set; }
        /// <summary>
        /// WMI Property LastStateName
        /// </summary>
        public string LastStateName { get; set; }
        /// <summary>
        /// WMI Property LastStatusMessageID
        /// </summary>
        public uint LastStatusMessageId { get; set; }
        /// <summary>
        /// WMI Property LastStatusMessageIDName
        /// </summary>
        public string LastStatusMessageIdName { get; set; }
        /// <summary>
        /// WMI Property LastStatusMessageIDSeverity
        /// </summary>
        public uint LastStatusMessageIdSeverity { get; set; }
        /// <summary>
        /// WMI Property LastStatusTime
        /// </summary>
        public DateTime LastStatusTime { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
    }
}
