using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdvertisementStatusInformation
    /// </summary>
    [WmiClass(Name = "SMS_AdvertisementStatusInformation")]
    public class SmsAdvertisementStatusInformation
    {
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property MessageName
        /// </summary>
        public string MessageName { get; set; }
        /// <summary>
        /// WMI Property MessageState
        /// </summary>
        public uint MessageState { get; set; }
        /// <summary>
        /// WMI Property MessageStateName
        /// </summary>
        public string MessageStateName { get; set; }
    }
}
