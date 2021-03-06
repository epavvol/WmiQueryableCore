using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AzureServicesTask
    /// </summary>
    [WmiClass(Name = "SMS_AzureServicesTask")]
    public class SmsAzureServicesTask
    {
        /// <summary>
        /// WMI Property AzureServiceId
        /// </summary>
        public uint AzureServiceId { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property TaskCreationTime
        /// </summary>
        public DateTime TaskCreationTime { get; set; }
        /// <summary>
        /// WMI Property TaskEndTime
        /// </summary>
        public DateTime TaskEndTime { get; set; }
        /// <summary>
        /// WMI Property TaskID
        /// </summary>
        public uint TaskId { get; set; }
        /// <summary>
        /// WMI Property TaskKeyValue
        /// </summary>
        public string TaskKeyValue { get; set; }
        /// <summary>
        /// WMI Property TaskStateId
        /// </summary>
        public uint TaskStateId { get; set; }
        /// <summary>
        /// WMI Property TaskTypeId
        /// </summary>
        public uint TaskTypeId { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
