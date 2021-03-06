using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMBulkEnrollmentProfiles
    /// </summary>
    [WmiClass(Name = "SMS_MDMBulkEnrollmentProfiles")]
    public class SmsMdmBulkEnrollmentProfiles
    {
        /// <summary>
        /// WMI Property Certificate_CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "Certificate_CI_UniqueID")]
        public string CertificateCiUniqueId { get; set; }
        /// <summary>
        /// WMI Property EnrolledDeviceCount
        /// </summary>
        public uint EnrolledDeviceCount { get; set; }
        /// <summary>
        /// WMI Property EnrollmentProxyPointType
        /// </summary>
        public uint EnrollmentProxyPointType { get; set; }
        /// <summary>
        /// WMI Property EnrollmentProxyPointUrl
        /// </summary>
        public string EnrollmentProxyPointUrl { get; set; }
        /// <summary>
        /// WMI Property IsCRLCheckEnabled
        /// </summary>
        public bool IsCrlCheckEnabled { get; set; }
        /// <summary>
        /// WMI Property MDMSiteCode
        /// </summary>
        public string MdmSiteCode { get; set; }
        /// <summary>
        /// WMI Property Profile_ID
        /// </summary>
        [WmiProperty(Name = "Profile_ID")]
        public uint ProfileId { get; set; }
        /// <summary>
        /// WMI Property Profile_UniqueID
        /// </summary>
        [WmiProperty(Name = "Profile_UniqueID")]
        public string ProfileUniqueId { get; set; }
        /// <summary>
        /// WMI Property ProfileDescription
        /// </summary>
        public string ProfileDescription { get; set; }
        /// <summary>
        /// WMI Property ProfileName
        /// </summary>
        public string ProfileName { get; set; }
        /// <summary>
        /// WMI Property ProfileType
        /// </summary>
        public uint ProfileType { get; set; }
        /// <summary>
        /// WMI Property ProfileVersion
        /// </summary>
        public uint ProfileVersion { get; set; }
        /// <summary>
        /// WMI Property ProxyPort
        /// </summary>
        public uint ProxyPort { get; set; }
        /// <summary>
        /// WMI Property ProxyServer
        /// </summary>
        public string ProxyServer { get; set; }
        /// <summary>
        /// WMI Property Wifi_CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "Wifi_CI_UniqueID")]
        public string WifiCiUniqueId { get; set; }
    }
}
