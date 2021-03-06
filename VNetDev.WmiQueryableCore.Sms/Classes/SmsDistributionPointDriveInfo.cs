using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionPointDriveInfo
    /// </summary>
    [WmiClass(Name = "SMS_DistributionPointDriveInfo")]
    public class SmsDistributionPointDriveInfo
    {
        /// <summary>
        /// WMI Property BytesFree
        /// </summary>
        public long BytesFree { get; set; }
        /// <summary>
        /// WMI Property BytesTotal
        /// </summary>
        public long BytesTotal { get; set; }
        /// <summary>
        /// WMI Property ConttentLibPriority
        /// </summary>
        public int ConttentLibPriority { get; set; }
        /// <summary>
        /// WMI Property Drive
        /// </summary>
        public string Drive { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property ObjectType
        /// </summary>
        public int ObjectType { get; set; }
        /// <summary>
        /// WMI Property PercentFree
        /// </summary>
        public int PercentFree { get; set; }
        /// <summary>
        /// WMI Property PkgSharePriority
        /// </summary>
        public int PkgSharePriority { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
    }
}
