using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MDMBulkEnrollmentPackages
    /// </summary>
    [WmiClass(Name = "SMS_MDMBulkEnrollmentPackages")]
    public class SmsMdmBulkEnrollmentPackages
    {
        /// <summary>
        /// WMI static method <c>ImportForProfile</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="certificate">WMI Property <c>Certificate</c> of type <c>string</c>.</param>
        /// <param name="certificateGuid">WMI Property <c>CertificateGUID</c> of type <c>string</c>.</param>
        /// <param name="packageName">WMI Property <c>PackageName</c> of type <c>string</c>.</param>
        /// <param name="profileGuid">WMI Property <c>ProfileGUID</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ImportForProfileDelegate(WmiContext wmiContext, string certificate = default, string certificateGuid = default, string packageName = default, string profileGuid = default);
        /// <summary>
        /// WMI static method <c>ImportForProfile</c>.
        /// </summary>
        public static ImportForProfileDelegate ImportForProfile;
        /// <summary>
        /// WMI Property CertificateId
        /// </summary>
        public string CertificateId { get; set; }
        /// <summary>
        /// WMI Property CreationTime
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// WMI Property ExpiryTime
        /// </summary>
        public DateTime ExpiryTime { get; set; }
        /// <summary>
        /// WMI Property Package_ID
        /// </summary>
        [WmiProperty(Name = "Package_ID")]
        public uint PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageName
        /// </summary>
        public string PackageName { get; set; }
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
        /// WMI Property ProfileName
        /// </summary>
        public string ProfileName { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public uint State { get; set; }
    }
}
