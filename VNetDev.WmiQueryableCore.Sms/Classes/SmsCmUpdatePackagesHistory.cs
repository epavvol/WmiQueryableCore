using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CM_UpdatePackagesHistory
    /// </summary>
    [WmiClass(Name = "SMS_CM_UpdatePackagesHistory")]
    public class SmsCmUpdatePackagesHistory
    {
        /// <summary>
        /// WMI Property ClientVersion
        /// </summary>
        public string ClientVersion { get; set; }
        /// <summary>
        /// WMI Property DateCreated
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// WMI Property DateReleased
        /// </summary>
        public DateTime DateReleased { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property FullVersion
        /// </summary>
        public string FullVersion { get; set; }
        /// <summary>
        /// WMI Property Impact
        /// </summary>
        public int Impact { get; set; }
        /// <summary>
        /// WMI Property LastUpdateTime
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
        /// <summary>
        /// WMI Property LocaleID
        /// </summary>
        public int LocaleId { get; set; }
        /// <summary>
        /// WMI Property MaxCMVersion
        /// </summary>
        public string MaxCmVersion { get; set; }
        /// <summary>
        /// WMI Property MinCMVersion
        /// </summary>
        public string MinCmVersion { get; set; }
        /// <summary>
        /// WMI Property MoreInfoLink
        /// </summary>
        public string MoreInfoLink { get; set; }
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
        /// WMI Property PrereqPackageName
        /// </summary>
        public string PrereqPackageName { get; set; }
        /// <summary>
        /// WMI Property PrereqPackageState
        /// </summary>
        public int PrereqPackageState { get; set; }
        /// <summary>
        /// WMI Property PublisherFlags
        /// </summary>
        public int PublisherFlags { get; set; }
        /// <summary>
        /// WMI Property State
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// WMI Property UpdateType
        /// </summary>
        public int UpdateType { get; set; }
        /// <summary>
        /// WMI Property WarningFlag
        /// </summary>
        public int WarningFlag { get; set; }
    }
}
