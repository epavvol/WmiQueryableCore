using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Azure_CloudServiceHist
    /// </summary>
    [WmiClass(Name = "SMS_Azure_CloudServiceHist")]
    public class SmsAzureCloudServiceHist
    {
        /// <summary>
        /// WMI Property ActionType
        /// </summary>
        public uint ActionType { get; set; }
        /// <summary>
        /// WMI Property AppName
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// WMI Property ClientAppID
        /// </summary>
        public string ClientAppId { get; set; }
        /// <summary>
        /// WMI Property CloudServiceName
        /// </summary>
        public string CloudServiceName { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public ulong Id { get; set; }
        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public uint ServiceType { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property TenantDBID
        /// </summary>
        public uint TenantDbid { get; set; }
        /// <summary>
        /// WMI Property UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
