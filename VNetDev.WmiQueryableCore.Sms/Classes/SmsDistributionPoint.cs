using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionPoint
    /// </summary>
    [WmiClass(Name = "SMS_DistributionPoint")]
    public class SmsDistributionPoint
    {
        /// <summary>
        /// WMI static method <c>VerifyPackage</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nalPath">WMI Property <c>NALPath</c> of type <c>string</c>.</param>
        /// <param name="packageId">WMI Property <c>PackageId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint VerifyPackageDelegate(WmiContext wmiContext, string nalPath = default, string packageId = default);
        /// <summary>
        /// WMI static method <c>VerifyPackage</c>.
        /// </summary>
        public static VerifyPackageDelegate VerifyPackage;
        
        /// <summary>
        /// WMI static method <c>CancelDistribution</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="nalPath">WMI Property <c>NALPath</c> of type <c>string</c>.</param>
        /// <param name="packageId">WMI Property <c>PackageId</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint CancelDistributionDelegate(WmiContext wmiContext, string nalPath = default, string packageId = default);
        /// <summary>
        /// WMI static method <c>CancelDistribution</c>.
        /// </summary>
        public static CancelDistributionDelegate CancelDistribution;
        /// <summary>
        /// WMI Property BitsEnabled
        /// </summary>
        public bool BitsEnabled { get; set; }
        /// <summary>
        /// WMI Property IsPeerDP
        /// </summary>
        public bool IsPeerDp { get; set; }
        /// <summary>
        /// WMI Property IsProtected
        /// </summary>
        public bool IsProtected { get; set; }
        /// <summary>
        /// WMI Property ISVData
        /// </summary>
        public ICollection<byte> IsvData { get; set; }
        /// <summary>
        /// WMI Property ISVDataSize
        /// </summary>
        public uint IsvDataSize { get; set; }
        /// <summary>
        /// WMI Property ISVString
        /// </summary>
        public string IsvString { get; set; }
        /// <summary>
        /// WMI Property LastRefreshTime
        /// </summary>
        public DateTime LastRefreshTime { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageType
        /// </summary>
        public uint PackageType { get; set; }
        /// <summary>
        /// WMI Property RefreshNow
        /// </summary>
        public bool RefreshNow { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// WMI Property SecureObjectID
        /// </summary>
        public string SecureObjectId { get; set; }
        /// <summary>
        /// WMI Property ServerNALPath
        /// </summary>
        public string ServerNalPath { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property SourceSite
        /// </summary>
        public string SourceSite { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
    }
}
