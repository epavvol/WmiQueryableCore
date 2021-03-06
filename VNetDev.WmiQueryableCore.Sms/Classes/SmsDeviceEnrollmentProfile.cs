using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DeviceEnrollmentProfile
    /// </summary>
    [WmiClass(Name = "SMS_DeviceEnrollmentProfile")]
    public class SmsDeviceEnrollmentProfile
    {
        /// <summary>
        /// WMI Property CertAuthorities
        /// </summary>
        public ICollection<string> CertAuthorities { get; set; }
        /// <summary>
        /// WMI Property CertCIUniqueID
        /// </summary>
        public string CertCiUniqueId { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DevicesContainerDN
        /// </summary>
        public string DevicesContainerDn { get; set; }
        /// <summary>
        /// WMI Property DevicesGroup
        /// </summary>
        public string DevicesGroup { get; set; }
        /// <summary>
        /// WMI Property EnrollmentSiteCode
        /// </summary>
        public string EnrollmentSiteCode { get; set; }
        /// <summary>
        /// WMI Property ManagementSiteCode
        /// </summary>
        public string ManagementSiteCode { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ProfileID
        /// </summary>
        public uint ProfileId { get; set; }
        /// <summary>
        /// WMI Property ProfileType
        /// </summary>
        public uint ProfileType { get; set; }
        /// <summary>
        /// WMI Property RecordExpiryMinutes
        /// </summary>
        public uint RecordExpiryMinutes { get; set; }
    }
}
