using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AzureEnvironments
    /// </summary>
    [WmiClass(Name = "SMS_AzureEnvironments")]
    public class SmsAzureEnvironments
    {
        /// <summary>
        /// WMI Property ActiveDirectoryEndpoint
        /// </summary>
        public string ActiveDirectoryEndpoint { get; set; }
        /// <summary>
        /// WMI Property CloudServiceSuffix
        /// </summary>
        public string CloudServiceSuffix { get; set; }
        /// <summary>
        /// WMI Property CMMicroServiceResourceEndpoint
        /// </summary>
        public string CmMicroServiceResourceEndpoint { get; set; }
        /// <summary>
        /// WMI Property EnvironmentName
        /// </summary>
        public string EnvironmentName { get; set; }
        /// <summary>
        /// WMI Property GalleryEndpoint
        /// </summary>
        public string GalleryEndpoint { get; set; }
        /// <summary>
        /// WMI Property GatewayService
        /// </summary>
        public string GatewayService { get; set; }
        /// <summary>
        /// WMI Property GraphEndpoint
        /// </summary>
        public string GraphEndpoint { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IntuneWebPortalLoginURL
        /// </summary>
        public string IntuneWebPortalLoginUrl { get; set; }
        /// <summary>
        /// WMI Property KeyVaultDNSSuffix
        /// </summary>
        public string KeyVaultDnsSuffix { get; set; }
        /// <summary>
        /// WMI Property KeyVaultEndpoint
        /// </summary>
        public string KeyVaultEndpoint { get; set; }
        /// <summary>
        /// WMI Property ManagementPortalURL
        /// </summary>
        public string ManagementPortalUrl { get; set; }
        /// <summary>
        /// WMI Property MDMEnrollmentURL
        /// </summary>
        public string MdmEnrollmentUrl { get; set; }
        /// <summary>
        /// WMI Property MicrosoftGraphEndpoint
        /// </summary>
        public string MicrosoftGraphEndpoint { get; set; }
        /// <summary>
        /// WMI Property PublishSettingsURL
        /// </summary>
        public string PublishSettingsUrl { get; set; }
        /// <summary>
        /// WMI Property ResourceManagerEndpoint
        /// </summary>
        public string ResourceManagerEndpoint { get; set; }
        /// <summary>
        /// WMI Property ServiceBusEndpointSuffix
        /// </summary>
        public string ServiceBusEndpointSuffix { get; set; }
        /// <summary>
        /// WMI Property ServiceManagementEndpoint
        /// </summary>
        public string ServiceManagementEndpoint { get; set; }
        /// <summary>
        /// WMI Property SQLDatabaseDNSSuffix
        /// </summary>
        public string SqlDatabaseDnsSuffix { get; set; }
        /// <summary>
        /// WMI Property StorageEndpointSuffix
        /// </summary>
        public string StorageEndpointSuffix { get; set; }
        /// <summary>
        /// WMI Property TrafficManagerDNSSuffix
        /// </summary>
        public string TrafficManagerDnsSuffix { get; set; }
    }
}
