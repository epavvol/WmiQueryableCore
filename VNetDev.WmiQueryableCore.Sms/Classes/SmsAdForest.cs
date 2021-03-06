using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_ADForest
    /// </summary>
    [WmiClass(Name = "SMS_ADForest")]
    public class SmsAdForest
    {
        /// <summary>
        /// WMI static method <c>DeleteDiscoveryData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="forceDelete">WMI Property <c>ForceDelete</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint DeleteDiscoveryDataDelegate(WmiContext wmiContext, uint forceDelete = default);
        /// <summary>
        /// WMI static method <c>DeleteDiscoveryData</c>.
        /// </summary>
        public static DeleteDiscoveryDataDelegate DeleteDiscoveryData;
        /// <summary>
        /// WMI Property Account
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// WMI Property CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// WMI Property CreatedOn
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DiscoveredADSites
        /// </summary>
        public uint DiscoveredAdSites { get; set; }
        /// <summary>
        /// WMI Property DiscoveredDomains
        /// </summary>
        public uint DiscoveredDomains { get; set; }
        /// <summary>
        /// WMI Property DiscoveredIPSubnets
        /// </summary>
        public uint DiscoveredIpSubnets { get; set; }
        /// <summary>
        /// WMI Property DiscoveredTrusts
        /// </summary>
        public uint DiscoveredTrusts { get; set; }
        /// <summary>
        /// WMI Property DiscoveryStatus
        /// </summary>
        public uint DiscoveryStatus { get; set; }
        /// <summary>
        /// WMI Property EnableDiscovery
        /// </summary>
        public bool EnableDiscovery { get; set; }
        /// <summary>
        /// WMI Property ForestFQDN
        /// </summary>
        public string ForestFqdn { get; set; }
        /// <summary>
        /// WMI Property ForestID
        /// </summary>
        public uint ForestId { get; set; }
        /// <summary>
        /// WMI Property ModifiedBy
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// WMI Property ModifiedOn
        /// </summary>
        public DateTime ModifiedOn { get; set; }
        /// <summary>
        /// WMI Property PublishingPath
        /// </summary>
        public string PublishingPath { get; set; }
        /// <summary>
        /// WMI Property PublishingStatus
        /// </summary>
        public uint PublishingStatus { get; set; }
    }
}
