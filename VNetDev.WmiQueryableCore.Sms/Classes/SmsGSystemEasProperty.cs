using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_EAS_Property
    /// </summary>
    [WmiClass(Name = "SMS_G_System_EAS_Property")]
    public class SmsGSystemEasProperty
    {
        /// <summary>
        /// WMI Property DeviceAccessControlRule
        /// </summary>
        public string DeviceAccessControlRule { get; set; }
        /// <summary>
        /// WMI Property DeviceAccessState
        /// </summary>
        public string DeviceAccessState { get; set; }
        /// <summary>
        /// WMI Property DeviceAccessStateReason
        /// </summary>
        public string DeviceAccessStateReason { get; set; }
        /// <summary>
        /// WMI Property DeviceID
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// WMI Property DeviceImei
        /// </summary>
        public string DeviceImei { get; set; }
        /// <summary>
        /// WMI Property DeviceMobileOperator
        /// </summary>
        public string DeviceMobileOperator { get; set; }
        /// <summary>
        /// WMI Property DeviceModel
        /// </summary>
        public string DeviceModel { get; set; }
        /// <summary>
        /// WMI Property DeviceOS
        /// </summary>
        public string DeviceOs { get; set; }
        /// <summary>
        /// WMI Property DeviceOSLanguage
        /// </summary>
        public string DeviceOsLanguage { get; set; }
        /// <summary>
        /// WMI Property DevicePhoneNumber
        /// </summary>
        public string DevicePhoneNumber { get; set; }
        /// <summary>
        /// WMI Property DevicePolicyApplicationStatus
        /// </summary>
        public string DevicePolicyApplicationStatus { get; set; }
        /// <summary>
        /// WMI Property DevicePolicyApplied
        /// </summary>
        public string DevicePolicyApplied { get; set; }
        /// <summary>
        /// WMI Property DeviceStatus
        /// </summary>
        public string DeviceStatus { get; set; }
        /// <summary>
        /// WMI Property DeviceType
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// WMI Property DeviceUserAgent
        /// </summary>
        public string DeviceUserAgent { get; set; }
        /// <summary>
        /// WMI Property DeviceWipeAckTimeUTC
        /// </summary>
        public DateTime DeviceWipeAckTimeUtc { get; set; }
        /// <summary>
        /// WMI Property DeviceWipeRequestTimeUTC
        /// </summary>
        public DateTime DeviceWipeRequestTimeUtc { get; set; }
        /// <summary>
        /// WMI Property DeviceWipeSentTimeUTC
        /// </summary>
        public DateTime DeviceWipeSentTimeUtc { get; set; }
        /// <summary>
        /// WMI Property EAS_Identity
        /// </summary>
        [WmiProperty(Name = "EAS_Identity")]
        public string EasIdentity { get; set; }
        /// <summary>
        /// WMI Property ExchangeServer
        /// </summary>
        public string ExchangeServer { get; set; }
        /// <summary>
        /// WMI Property FirstSyncTimeUTC
        /// </summary>
        public DateTime FirstSyncTimeUtc { get; set; }
        /// <summary>
        /// WMI Property FriendlyName
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// WMI Property IsRemoteWipeSupported
        /// </summary>
        public bool IsRemoteWipeSupported { get; set; }
        /// <summary>
        /// WMI Property LastPolicyUpdateTimeUTC
        /// </summary>
        public DateTime LastPolicyUpdateTimeUtc { get; set; }
        /// <summary>
        /// WMI Property LastSuccessSyncTimeUTC
        /// </summary>
        public DateTime LastSuccessSyncTimeUtc { get; set; }
        /// <summary>
        /// WMI Property LastSyncAttemptTimeUTC
        /// </summary>
        public DateTime LastSyncAttemptTimeUtc { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property SMSWipeStatus
        /// </summary>
        public uint SmsWipeStatus { get; set; }
        /// <summary>
        /// WMI Property StatusNote
        /// </summary>
        public string StatusNote { get; set; }
        /// <summary>
        /// WMI Property UserDomain
        /// </summary>
        public string UserDomain { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
    }
}
