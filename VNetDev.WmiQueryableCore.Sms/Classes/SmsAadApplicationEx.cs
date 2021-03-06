using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AAD_Application_Ex
    /// </summary>
    [WmiClass(Name = "SMS_AAD_Application_Ex")]
    public class SmsAadApplicationEx
    {
        /// <summary>
        /// WMI static method <c>AzureServiceAppRelationExists</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="id">WMI Property <c>ID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AzureServiceAppRelationExistsDelegate(WmiContext wmiContext, uint id = default);
        /// <summary>
        /// WMI static method <c>AzureServiceAppRelationExists</c>.
        /// </summary>
        public static AzureServiceAppRelationExistsDelegate AzureServiceAppRelationExists;
        /// <summary>
        /// WMI Property ApplicationCreationTime
        /// </summary>
        public DateTime ApplicationCreationTime { get; set; }
        /// <summary>
        /// WMI Property AssociatedAADApplications
        /// </summary>
        public ICollection<uint> AssociatedAadApplications { get; set; }
        /// <summary>
        /// WMI Property ClientID
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
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
        /// WMI Property SecretKeyCreationTime
        /// </summary>
        public DateTime SecretKeyCreationTime { get; set; }
        /// <summary>
        /// WMI Property SecretKeyExpiry
        /// </summary>
        public DateTime SecretKeyExpiry { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Source
        /// </summary>
        public uint Source { get; set; }
        /// <summary>
        /// WMI Property TenantID
        /// </summary>
        public uint TenantId { get; set; }
    }
}
