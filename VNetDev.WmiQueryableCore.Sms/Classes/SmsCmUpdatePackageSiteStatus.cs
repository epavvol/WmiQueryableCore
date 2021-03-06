using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CM_UpdatePackageSiteStatus
    /// </summary>
    [WmiClass(Name = "SMS_CM_UpdatePackageSiteStatus")]
    public class SmsCmUpdatePackageSiteStatus
    {
        /// <summary>
        /// WMI method <c>UpdatePackageSiteState</c> describing delegate.
        /// <param name="state">WMI Property <c>State</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint UpdatePackageSiteStateDelegate(uint state = default);
        /// <summary>
        /// WMI method <c>UpdatePackageSiteState</c>.
        /// </summary>
        public UpdatePackageSiteStateDelegate UpdatePackageSiteState;
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageGuid
        /// </summary>
        public string PackageGuid { get; set; }
        /// <summary>
        /// WMI Property PrereqFlag
        /// </summary>
        public int PrereqFlag { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property SiteNumber
        /// </summary>
        public int SiteNumber { get; set; }
        /// <summary>
        /// WMI Property SiteServerName
        /// </summary>
        public string SiteServerName { get; set; }
        /// <summary>
        /// WMI Property SiteType
        /// </summary>
        public int SiteType { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public int State { get; set; }
    }
}
