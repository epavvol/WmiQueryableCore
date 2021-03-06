using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GEH_System_SOFTWARE_LICENSING_PRODUCT
    /// </summary>
    [WmiClass(Name = "SMS_GEH_System_SOFTWARE_LICENSING_PRODUCT")]
    public class SmsGehSystemSoftwareLicensingProduct
    {
        /// <summary>
        /// WMI Property ApplicationID
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property EvaluationEndDate
        /// </summary>
        public DateTime EvaluationEndDate { get; set; }
        /// <summary>
        /// WMI Property GracePeriodRemaining
        /// </summary>
        public uint GracePeriodRemaining { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// WMI Property LicenseStatus
        /// </summary>
        public uint LicenseStatus { get; set; }
        /// <summary>
        /// WMI Property MachineURL
        /// </summary>
        public string MachineUrl { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OfflineInstallationId
        /// </summary>
        public string OfflineInstallationId { get; set; }
        /// <summary>
        /// WMI Property PartialProductKey
        /// </summary>
        public string PartialProductKey { get; set; }
        /// <summary>
        /// WMI Property ProcessorURL
        /// </summary>
        public string ProcessorUrl { get; set; }
        /// <summary>
        /// WMI Property ProductKeyID
        /// </summary>
        public string ProductKeyId { get; set; }
        /// <summary>
        /// WMI Property ProductKeyURL
        /// </summary>
        public string ProductKeyUrl { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UseLicenseURL
        /// </summary>
        public string UseLicenseUrl { get; set; }
    }
}
