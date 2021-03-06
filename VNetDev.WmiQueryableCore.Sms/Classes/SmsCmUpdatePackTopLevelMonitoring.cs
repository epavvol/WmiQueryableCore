using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_CM_UpdatePackTopLevelMonitoring
    /// </summary>
    [WmiClass(Name = "SMS_CM_UpdatePackTopLevelMonitoring")]
    public class SmsCmUpdatePackTopLevelMonitoring
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
        /// WMI Property SiteNumber
        /// </summary>
        public int SiteNumber { get; set; }
        /// <summary>
        /// WMI Property SiteType
        /// </summary>
        public int SiteType { get; set; }
        /// <summary>
        /// WMI Property StageCompleted
        /// </summary>
        public int StageCompleted { get; set; }
        /// <summary>
        /// WMI Property StageId
        /// </summary>
        public int StageId { get; set; }
        /// <summary>
        /// WMI Property StageName
        /// </summary>
        public string StageName { get; set; }
    }
}
