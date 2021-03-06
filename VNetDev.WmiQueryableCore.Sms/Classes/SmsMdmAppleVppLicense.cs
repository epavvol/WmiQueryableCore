using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMAppleVppLicense
    /// </summary>
    [WmiClass(Name = "SMS_MDMAppleVppLicense")]
    public class SmsMdmAppleVppLicense
    {
        /// <summary>
        /// WMI Property ApplicationID
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary>
        /// WMI Property ApplicationPricingParam
        /// </summary>
        public string ApplicationPricingParam { get; set; }
        /// <summary>
        /// WMI Property AvailableLicenses
        /// </summary>
        public uint AvailableLicenses { get; set; }
        /// <summary>
        /// WMI Property BundleID
        /// </summary>
        public string BundleId { get; set; }
        /// <summary>
        /// WMI Property DeepLinkUrl
        /// </summary>
        public string DeepLinkUrl { get; set; }
        /// <summary>
        /// WMI Property InfoLink
        /// </summary>
        public string InfoLink { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property ReleaseDate
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// WMI Property SupportedDevices
        /// </summary>
        public string SupportedDevices { get; set; }
        /// <summary>
        /// WMI Property SupportsDeviceLicensing
        /// </summary>
        public uint SupportsDeviceLicensing { get; set; }
        /// <summary>
        /// WMI Property Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// WMI Property TotalLicenses
        /// </summary>
        public uint TotalLicenses { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// WMI Property VppIntuneTokenId
        /// </summary>
        public string VppIntuneTokenId { get; set; }
    }
}
