using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Application
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Application")]
    public class SmsAadApplication
    {
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property IdentifierUri
        /// </summary>
        public string IdentifierUri { get; set; }
        /// <summary>
        /// WMI Property IsClientApp
        /// </summary>
        public bool IsClientApp { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ReplyUrl
        /// </summary>
        public string ReplyUrl { get; set; }
        /// <summary>
        /// WMI Property SecretKey
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// WMI Property SecretKeyExpiry
        /// </summary>
        public DateTime SecretKeyExpiry { get; set; }
        /// <summary>
        /// WMI Property TenantID
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
