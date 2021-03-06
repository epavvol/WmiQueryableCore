using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AzureService
    /// </summary>
    [WmiClass(Name = "SMS_AzureService")]
    public class SmsAzureService
    {
        /// <summary>
        /// WMI static method <c>Start</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="azureServiceId">WMI Property <c>AzureServiceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint StartDelegate(WmiContext wmiContext, uint azureServiceId = default);
        /// <summary>
        /// WMI static method <c>Start</c>.
        /// </summary>
        public static StartDelegate Start;
        
        /// <summary>
        /// WMI static method <c>Stop</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="azureServiceId">WMI Property <c>AzureServiceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint StopDelegate(WmiContext wmiContext, uint azureServiceId = default);
        /// <summary>
        /// WMI static method <c>Stop</c>.
        /// </summary>
        public static StopDelegate Stop;
        
        /// <summary>
        /// WMI static method <c>SyncConfig</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="azureServiceId">WMI Property <c>AzureServiceID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint SyncConfigDelegate(WmiContext wmiContext, uint azureServiceId = default);
        /// <summary>
        /// WMI static method <c>SyncConfig</c>.
        /// </summary>
        public static SyncConfigDelegate SyncConfig;
        /// <summary>
        /// WMI Property AADApplicationId
        /// </summary>
        public uint AadApplicationId { get; set; }
        /// <summary>
        /// WMI Property AffinityGroup
        /// </summary>
        public string AffinityGroup { get; set; }
        /// <summary>
        /// WMI Property AzureCloudServiceId
        /// </summary>
        public uint AzureCloudServiceId { get; set; }
        /// <summary>
        /// WMI Property AzureEnvironmentId
        /// </summary>
        public uint AzureEnvironmentId { get; set; }
        /// <summary>
        /// WMI Property AzureServiceID
        /// </summary>
        public uint AzureServiceId { get; set; }
        /// <summary>
        /// WMI Property ClientCertRevocationEnabled
        /// </summary>
        public bool ClientCertRevocationEnabled { get; set; }
        /// <summary>
        /// WMI Property ConfigurationVersion
        /// </summary>
        public uint ConfigurationVersion { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property DeploymentModel
        /// </summary>
        public uint DeploymentModel { get; set; }
        /// <summary>
        /// WMI Property DeploymentSlot
        /// </summary>
        public string DeploymentSlot { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property Flags
        /// </summary>
        public uint Flags { get; set; }
        /// <summary>
        /// WMI Property Fqdn
        /// </summary>
        public string Fqdn { get; set; }
        /// <summary>
        /// WMI Property ManagementCertificate
        /// </summary>
        public string ManagementCertificate { get; set; }
        /// <summary>
        /// WMI Property ManagementCertificateType
        /// </summary>
        public uint ManagementCertificateType { get; set; }
        /// <summary>
        /// WMI Property ManagementThumbprint
        /// </summary>
        public string ManagementThumbprint { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property NetworkOutUsage
        /// </summary>
        public float NetworkOutUsage { get; set; }
        /// <summary>
        /// WMI Property NumberOfInstances
        /// </summary>
        public uint NumberOfInstances { get; set; }
        /// <summary>
        /// WMI Property ProxyCertificateConfig
        /// </summary>
        public string ProxyCertificateConfig { get; set; }
        /// <summary>
        /// WMI Property ProxySecurityProtocol
        /// </summary>
        public uint ProxySecurityProtocol { get; set; }
        /// <summary>
        /// WMI Property Region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// WMI Property RootCertificate
        /// </summary>
        public string RootCertificate { get; set; }
        /// <summary>
        /// WMI Property RootCertThumbprint
        /// </summary>
        public string RootCertThumbprint { get; set; }
        /// <summary>
        /// WMI Property SerializedServiceCertificate
        /// </summary>
        public string SerializedServiceCertificate { get; set; }
        /// <summary>
        /// WMI Property ServiceCertificate
        /// </summary>
        public string ServiceCertificate { get; set; }
        /// <summary>
        /// WMI Property ServiceCName
        /// </summary>
        public string ServiceCName { get; set; }
        /// <summary>
        /// WMI Property ServiceThumbprint
        /// </summary>
        public string ServiceThumbprint { get; set; }
        /// <summary>
        /// WMI Property ServiceThumbprintAlgorithm
        /// </summary>
        public string ServiceThumbprintAlgorithm { get; set; }
        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public string ServiceType { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
        /// <summary>
        /// WMI Property StatusDetails
        /// </summary>
        public uint StatusDetails { get; set; }
        /// <summary>
        /// WMI Property StorageCriticalThreshold
        /// </summary>
        public uint StorageCriticalThreshold { get; set; }
        /// <summary>
        /// WMI Property StorageQuotaGrow
        /// </summary>
        public bool StorageQuotaGrow { get; set; }
        /// <summary>
        /// WMI Property StorageQuotaInGB
        /// </summary>
        public uint StorageQuotaInGb { get; set; }
        /// <summary>
        /// WMI Property StorageServiceName
        /// </summary>
        public string StorageServiceName { get; set; }
        /// <summary>
        /// WMI Property StorageUsage
        /// </summary>
        public float StorageUsage { get; set; }
        /// <summary>
        /// WMI Property StorageWarningThreshold
        /// </summary>
        public uint StorageWarningThreshold { get; set; }
        /// <summary>
        /// WMI Property SubCACertificate
        /// </summary>
        public string SubCaCertificate { get; set; }
        /// <summary>
        /// WMI Property SubCACertThumbprint
        /// </summary>
        public string SubCaCertThumbprint { get; set; }
        /// <summary>
        /// WMI Property SubscriptionID
        /// </summary>
        public string SubscriptionId { get; set; }
        /// <summary>
        /// WMI Property TrafficCriticalThreshold
        /// </summary>
        public uint TrafficCriticalThreshold { get; set; }
        /// <summary>
        /// WMI Property TrafficOutInGB
        /// </summary>
        public uint TrafficOutInGb { get; set; }
        /// <summary>
        /// WMI Property TrafficOutStopService
        /// </summary>
        public bool TrafficOutStopService { get; set; }
        /// <summary>
        /// WMI Property TrafficOutUsage
        /// </summary>
        public float TrafficOutUsage { get; set; }
        /// <summary>
        /// WMI Property TrafficWarningThreshold
        /// </summary>
        public uint TrafficWarningThreshold { get; set; }
    }
}
