using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PackageStatus
    /// </summary>
    [WmiClass(Name = "SMS_PackageStatus")]
    public class SmsPackageStatus
    {
        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// WMI Property PackageID
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property Personality
        /// </summary>
        public int Personality { get; set; }
        /// <summary>
        /// WMI Property PkgServer
        /// </summary>
        public string PkgServer { get; set; }
        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// WMI Property Type
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// WMI Property UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
