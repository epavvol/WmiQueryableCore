using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionStatus
    /// </summary>
    [WmiClass(Name = "SMS_DistributionStatus")]
    public class SmsDistributionStatus
    {
        /// <summary>
        /// WMI Property Assets
        /// </summary>
        public uint Assets { get; set; }
        /// <summary>
        /// WMI Property LastUpdateDate
        /// </summary>
        public DateTime LastUpdateDate { get; set; }
        /// <summary>
        /// WMI Property MessageCategory
        /// </summary>
        public uint MessageCategory { get; set; }
        /// <summary>
        /// WMI Property ObjectID
        /// </summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// WMI Property ObjectTypeID
        /// </summary>
        public uint ObjectTypeId { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public uint Type { get; set; }
    }
}
