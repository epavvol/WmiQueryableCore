using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AdvertisementInfo
    /// </summary>
    [WmiClass(Name = "SMS_AdvertisementInfo")]
    public class SmsAdvertisementInfo
    {
        /// <summary>
        /// WMI Property AdvertFlags
        /// </summary>
        public uint AdvertFlags { get; set; }
        /// <summary>
        /// WMI Property AdvertisementID
        /// </summary>
        public string AdvertisementId { get; set; }
        /// <summary>
        /// WMI Property AdvertisementName
        /// </summary>
        public string AdvertisementName { get; set; }
        /// <summary>
        /// WMI Property AdvertisementSourceSite
        /// </summary>
        public string AdvertisementSourceSite { get; set; }
        /// <summary>
        /// WMI Property AssignmentID
        /// </summary>
        public uint AssignmentId { get; set; }
        /// <summary>
        /// WMI Property CollectionID
        /// </summary>
        public string CollectionId { get; set; }
        /// <summary>
        /// WMI Property CollectionName
        /// </summary>
        public string CollectionName { get; set; }
        /// <summary>
        /// WMI Property ExpirationTime
        /// </summary>
        public DateTime ExpirationTime { get; set; }
        /// <summary>
        /// WMI Property OfferType
        /// </summary>
        public uint OfferType { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageLanguage
        /// </summary>
        public string PackageLanguage { get; set; }
        /// <summary>
        /// WMI Property PackageManufacturer
        /// </summary>
        public string PackageManufacturer { get; set; }
        /// <summary>
        /// WMI Property PackageName
        /// </summary>
        public string PackageName { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property PackageVersion
        /// </summary>
        public string PackageVersion { get; set; }
        /// <summary>
        /// WMI Property PresentTime
        /// </summary>
        public DateTime PresentTime { get; set; }
        /// <summary>
        /// WMI Property ProgramFlags
        /// </summary>
        public uint ProgramFlags { get; set; }
        /// <summary>
        /// WMI Property ProgramName
        /// </summary>
        public string ProgramName { get; set; }
        /// <summary>
        /// WMI Property TimeFlags
        /// </summary>
        public uint TimeFlags { get; set; }
    }
}
