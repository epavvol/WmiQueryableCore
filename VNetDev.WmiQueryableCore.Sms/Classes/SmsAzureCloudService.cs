using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_Azure_CloudService
    /// </summary>
    [WmiClass(Name = "SMS_Azure_CloudService")]
    public class SmsAzureCloudService
    {
        /// <summary>
        /// WMI Property AssociatedAADWebApplications
        /// </summary>
        public ICollection<uint> AssociatedAadWebApplications { get; set; }
        /// <summary>
        /// WMI Property AuthenticationType
        /// </summary>
        public uint AuthenticationType { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public uint ServiceType { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
    }
}
