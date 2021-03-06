using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CM_UpdatePackDetailedSiteStatus
    /// </summary>
    [WmiClass(Name = "SMS_CM_UpdatePackDetailedSiteStatus")]
    public class SmsCmUpdatePackDetailedSiteStatus
    {
        /// <summary>
        /// WMI Property MessageTime
        /// </summary>
        public DateTime MessageTime { get; set; }
        /// <summary>
        /// WMI Property PackageGuid
        /// </summary>
        public string PackageGuid { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteInstallID
        /// </summary>
        public int SiteInstallId { get; set; }
        /// <summary>
        /// WMI Property SiteNumber
        /// </summary>
        public int SiteNumber { get; set; }
        /// <summary>
        /// WMI Property StatusDescription
        /// </summary>
        public string StatusDescription { get; set; }
        /// <summary>
        /// WMI Property StatusID
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// WMI Property StatusName
        /// </summary>
        public string StatusName { get; set; }
        /// <summary>
        /// WMI Property SubStatusID
        /// </summary>
        public int SubStatusId { get; set; }
    }
}
