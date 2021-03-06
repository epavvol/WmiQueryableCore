using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_TS_LICENSE_KEY_PACK
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_TS_LICENSE_KEY_PACK")]
    public class SmsGhSystemTsLicenseKeyPack
    {
        /// <summary>
        /// WMI Property AvailableLicenses
        /// </summary>
        public uint AvailableLicenses { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IssuedLicenses
        /// </summary>
        public uint IssuedLicenses { get; set; }
        /// <summary>
        /// WMI Property KeyPackId
        /// </summary>
        public uint KeyPackId { get; set; }
        /// <summary>
        /// WMI Property KeyPackType
        /// </summary>
        public uint KeyPackType { get; set; }
        /// <summary>
        /// WMI Property ProductType
        /// </summary>
        public uint ProductType { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
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
        /// WMI Property TotalLicenses
        /// </summary>
        public uint TotalLicenses { get; set; }
    }
}
