using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_LifecycleDetectedGroups
    /// </summary>
    [WmiClass(Name = "SMS_LifecycleDetectedGroups")]
    public class SmsLifecycleDetectedGroups
    {
        /// <summary>
        /// WMI Property Category
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// WMI Property ExtendedSupportEndDate
        /// </summary>
        public string ExtendedSupportEndDate { get; set; }
        /// <summary>
        /// WMI Property ExtendedSupportEndDateAsDate
        /// </summary>
        public DateTime ExtendedSupportEndDateAsDate { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// WMI Property GroupName
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// WMI Property InstallCount
        /// </summary>
        public uint InstallCount { get; set; }
        /// <summary>
        /// WMI Property MainstreamSupportEndDate
        /// </summary>
        public string MainstreamSupportEndDate { get; set; }
        /// <summary>
        /// WMI Property MainstreamSupportEndDateAsDate
        /// </summary>
        public DateTime MainstreamSupportEndDateAsDate { get; set; }
        /// <summary>
        /// WMI Property MoreInformationLink
        /// </summary>
        public string MoreInformationLink { get; set; }
        /// <summary>
        /// WMI Property ScanData0
        /// </summary>
        public string ScanData0 { get; set; }
        /// <summary>
        /// WMI Property ScanData1
        /// </summary>
        public string ScanData1 { get; set; }
        /// <summary>
        /// WMI Property ScanData2
        /// </summary>
        public string ScanData2 { get; set; }
        /// <summary>
        /// WMI Property ScanType
        /// </summary>
        public uint ScanType { get; set; }
    }
}
