using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SummarizerStatus
    /// </summary>
    [WmiClass(Name = "SMS_SummarizerStatus")]
    public class SmsSummarizerStatus
    {
        /// <summary>
        /// WMI Property GUID_ID
        /// </summary>
        [WmiProperty(Name = "GUID_ID")]
        public string GuidId { get; set; }
        /// <summary>
        /// WMI Property MessageDLL
        /// </summary>
        public string MessageDll { get; set; }
        /// <summary>
        /// WMI Property MessageID
        /// </summary>
        public uint MessageId { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property Updated
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
