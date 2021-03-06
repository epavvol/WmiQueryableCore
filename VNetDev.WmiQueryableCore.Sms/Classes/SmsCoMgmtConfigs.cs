using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CoMgmtConfigs
    /// </summary>
    [WmiClass(Name = "SMS_CoMgmtConfigs")]
    public class SmsCoMgmtConfigs
    {
        /// <summary>
        /// WMI static method <c>AddTenantCollectionMapping</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="collectionSiteId">WMI Property <c>CollectionSiteID</c> of type <c>string</c>.</param>
        /// <param name="tenantId">WMI Property <c>TenantID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint AddTenantCollectionMappingDelegate(WmiContext wmiContext, string collectionSiteId = default, string tenantId = default);
        /// <summary>
        /// WMI static method <c>AddTenantCollectionMapping</c>.
        /// </summary>
        public static AddTenantCollectionMappingDelegate AddTenantCollectionMapping;
        
        /// <summary>
        /// WMI static method <c>RemoveTenantCollectionMapping</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tenantId">WMI Property <c>TenantID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint RemoveTenantCollectionMappingDelegate(WmiContext wmiContext, string tenantId = default);
        /// <summary>
        /// WMI static method <c>RemoveTenantCollectionMapping</c>.
        /// </summary>
        public static RemoveTenantCollectionMappingDelegate RemoveTenantCollectionMapping;
        
        /// <summary>
        /// WMI static method <c>GetTenantCollectionMapping</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="tenantId">WMI Property <c>TenantID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>uint</c>.</returns>
        /// </summary>
        public delegate uint GetTenantCollectionMappingDelegate(WmiContext wmiContext, string tenantId = default);
        /// <summary>
        /// WMI static method <c>GetTenantCollectionMapping</c>.
        /// </summary>
        public static GetTenantCollectionMappingDelegate GetTenantCollectionMapping;
        /// <summary>
        /// WMI Property AADTenantID
        /// </summary>
        public string AadTenantId { get; set; }
        /// <summary>
        /// WMI Property DataWarehouseUrl
        /// </summary>
        public string DataWarehouseUrl { get; set; }
        /// <summary>
        /// WMI Property ExcludedCollectionID
        /// </summary>
        public string ExcludedCollectionId { get; set; }
        /// <summary>
        /// WMI Property LogonRandomization
        /// </summary>
        public uint LogonRandomization { get; set; }
        /// <summary>
        /// WMI Property MDMClientAppID
        /// </summary>
        public string MdmClientAppId { get; set; }
        /// <summary>
        /// WMI Property MDMEnrollmentDuration
        /// </summary>
        public uint MdmEnrollmentDuration { get; set; }
        /// <summary>
        /// WMI Property MDMEnrollmentDurationPilot
        /// </summary>
        public uint MdmEnrollmentDurationPilot { get; set; }
        /// <summary>
        /// WMI Property MDMEnrollmentRetries
        /// </summary>
        public uint MdmEnrollmentRetries { get; set; }
        /// <summary>
        /// WMI Property MDMEnrollmentRetryInterval
        /// </summary>
        public uint MdmEnrollmentRetryInterval { get; set; }
        /// <summary>
        /// WMI Property MDMEnrollmentUrl
        /// </summary>
        public string MdmEnrollmentUrl { get; set; }
        /// <summary>
        /// WMI Property MDMServiceResourceID
        /// </summary>
        public string MdmServiceResourceId { get; set; }
        /// <summary>
        /// WMI Property MDMServiceUri
        /// </summary>
        public string MdmServiceUri { get; set; }
        /// <summary>
        /// WMI Property MDMTenantID
        /// </summary>
        public string MdmTenantId { get; set; }
    }
}
