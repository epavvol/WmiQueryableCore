using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_AllDistributionPoint
    /// </summary>
    [WmiClass(Name = "SMS_AllDistributionPoint")]
    public class SmsAllDistributionPoint
    {
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
    }
}
