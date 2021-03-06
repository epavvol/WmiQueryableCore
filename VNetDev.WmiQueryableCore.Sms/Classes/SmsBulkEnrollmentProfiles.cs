using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_BulkEnrollmentProfiles
    /// </summary>
    [WmiClass(Name = "SMS_BulkEnrollmentProfiles")]
    public class SmsBulkEnrollmentProfiles
    {
        /// <summary>
        /// WMI static method <c>GenerateProvisioningXML</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="bulkEnrollmentProfileId">WMI Property <c>BulkEnrollmentProfileID</c> of type <c>string</c>.</param>
        /// <param name="encrytionPassword">WMI Property <c>EncrytionPassword</c> of type <c>string</c>.</param>
        /// <param name="isEncrypted">WMI Property <c>IsEncrypted</c> of type <c>bool</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GenerateProvisioningXmlDelegate(WmiContext wmiContext, string bulkEnrollmentProfileId = default, string encrytionPassword = default, bool isEncrypted = default);
        /// <summary>
        /// WMI static method <c>GenerateProvisioningXML</c>.
        /// </summary>
        public static GenerateProvisioningXmlDelegate GenerateProvisioningXml;
        /// <summary>
        /// WMI Property Certificate_CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "Certificate_CI_UniqueID")]
        public ICollection<string> CertificateCiUniqueId { get; set; }
        /// <summary>
        /// WMI Property EnrollmentProxyPointType
        /// </summary>
        public uint EnrollmentProxyPointType { get; set; }
        /// <summary>
        /// WMI Property EnrollProxyPointServerNames
        /// </summary>
        public ICollection<string> EnrollProxyPointServerNames { get; set; }
        /// <summary>
        /// WMI Property ExpirationDate
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// WMI Property FriendlyNamePrefix
        /// </summary>
        public string FriendlyNamePrefix { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IsEnabled
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// WMI Property ProfileDescription
        /// </summary>
        public string ProfileDescription { get; set; }
        /// <summary>
        /// WMI Property ProfileID
        /// </summary>
        public uint ProfileId { get; set; }
        /// <summary>
        /// WMI Property ProfileName
        /// </summary>
        public string ProfileName { get; set; }
        /// <summary>
        /// WMI Property ProxyPort
        /// </summary>
        public uint ProxyPort { get; set; }
        /// <summary>
        /// WMI Property ProxyServer
        /// </summary>
        public string ProxyServer { get; set; }
        /// <summary>
        /// WMI Property Thumbprint
        /// </summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// WMI Property UserName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WMI Property Wifi_CI_UniqueID
        /// </summary>
        [WmiProperty(Name = "Wifi_CI_UniqueID")]
        public string WifiCiUniqueId { get; set; }
    }
}
