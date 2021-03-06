using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_LicensedVppApps
    /// </summary>
    [WmiClass(Name = "SMS_LicensedVppApps")]
    public class SmsLicensedVppApps
    {
        /// <summary>
        /// WMI Property ApplicationID
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary>
        /// WMI Property ApplicationMetadata
        /// </summary>
        public string ApplicationMetadata { get; set; }
        /// <summary>
        /// WMI Property ApproximateSize
        /// </summary>
        public string ApproximateSize { get; set; }
        /// <summary>
        /// WMI Property AvailableLicenses
        /// </summary>
        public int AvailableLicenses { get; set; }
        /// <summary>
        /// WMI Property ContentLastModified
        /// </summary>
        public DateTime ContentLastModified { get; set; }
        /// <summary>
        /// WMI Property CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// WMI Property DisplayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// WMI Property LastSuccessfulSync
        /// </summary>
        public DateTime LastSuccessfulSync { get; set; }
        /// <summary>
        /// WMI Property LastSync
        /// </summary>
        public DateTime LastSync { get; set; }
        /// <summary>
        /// WMI Property LicenseType
        /// </summary>
        public uint LicenseType { get; set; }
        /// <summary>
        /// WMI Property OrganizationName
        /// </summary>
        public string OrganizationName { get; set; }
        /// <summary>
        /// WMI Property Platform
        /// </summary>
        public uint Platform { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property SoftwareVersion
        /// </summary>
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// WMI Property StoreCategory
        /// </summary>
        public string StoreCategory { get; set; }
        /// <summary>
        /// WMI Property StoreLink
        /// </summary>
        public string StoreLink { get; set; }
        /// <summary>
        /// WMI Property SupportedLanguages
        /// </summary>
        public string SupportedLanguages { get; set; }
        /// <summary>
        /// WMI Property SupportedProcessors
        /// </summary>
        public string SupportedProcessors { get; set; }
        /// <summary>
        /// WMI Property TokenName
        /// </summary>
        public string TokenName { get; set; }
        /// <summary>
        /// WMI Property TokenType
        /// </summary>
        public uint TokenType { get; set; }
        /// <summary>
        /// WMI Property TotalLicenses
        /// </summary>
        public int TotalLicenses { get; set; }
    }
}
