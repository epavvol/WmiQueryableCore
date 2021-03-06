using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_DistributionPointInfoBase
    /// </summary>
    [WmiClass(Name = "SMS_DistributionPointInfoBase")]
    public class SmsDistributionPointInfoBase
    {
        /// <summary>
        /// WMI Property AddressScheduleEnabled
        /// </summary>
        public bool AddressScheduleEnabled { get; set; }
        /// <summary>
        /// WMI Property BindExcept
        /// </summary>
        public string BindExcept { get; set; }
        /// <summary>
        /// WMI Property BindPolicy
        /// </summary>
        public bool BindPolicy { get; set; }
        /// <summary>
        /// WMI Property BitsEnabled
        /// </summary>
        public bool BitsEnabled { get; set; }
        /// <summary>
        /// WMI Property CertificateType
        /// </summary>
        public bool CertificateType { get; set; }
        /// <summary>
        /// WMI Property Communication
        /// </summary>
        public uint Communication { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DPFlags
        /// </summary>
        public uint DpFlags { get; set; }
        /// <summary>
        /// WMI Property Drive
        /// </summary>
        public string Drive { get; set; }
        /// <summary>
        /// WMI Property EnableLEDBAT
        /// </summary>
        public bool EnableLedbat { get; set; }
        /// <summary>
        /// WMI Property GroupCount
        /// </summary>
        public uint GroupCount { get; set; }
        /// <summary>
        /// WMI Property HasRelationship
        /// </summary>
        public bool HasRelationship { get; set; }
        /// <summary>
        /// WMI Property HealthCheckEnabled
        /// </summary>
        public bool HealthCheckEnabled { get; set; }
        /// <summary>
        /// WMI Property HealthCheckPriority
        /// </summary>
        public uint HealthCheckPriority { get; set; }
        /// <summary>
        /// WMI Property HealthCheckSchedule
        /// </summary>
        public string HealthCheckSchedule { get; set; }
        /// <summary>
        /// WMI Property ID
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// WMI Property IdentityGUID
        /// </summary>
        public string IdentityGuid { get; set; }
        /// <summary>
        /// WMI Property InternetFacing
        /// </summary>
        public bool InternetFacing { get; set; }
        /// <summary>
        /// WMI Property IsActive
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// WMI Property IsMulticast
        /// </summary>
        public bool IsMulticast { get; set; }
        /// <summary>
        /// WMI Property IsPeerDP
        /// </summary>
        public bool IsPeerDp { get; set; }
        /// <summary>
        /// WMI Property IsProtected
        /// </summary>
        public bool IsProtected { get; set; }
        /// <summary>
        /// WMI Property IsPullDP
        /// </summary>
        public bool IsPullDp { get; set; }
        /// <summary>
        /// WMI Property IsPXE
        /// </summary>
        public bool IsPxe { get; set; }
        /// <summary>
        /// WMI Property MaintenanceMode
        /// </summary>
        public uint MaintenanceMode { get; set; }
        /// <summary>
        /// WMI Property MaintenanceModeLastStartTime
        /// </summary>
        public DateTime MaintenanceModeLastStartTime { get; set; }
        /// <summary>
        /// WMI Property NALPath
        /// </summary>
        public string NalPath { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OperatingSystem
        /// </summary>
        public string OperatingSystem { get; set; }
        /// <summary>
        /// WMI Property PreStagingAllowed
        /// </summary>
        public bool PreStagingAllowed { get; set; }
        /// <summary>
        /// WMI Property Priority
        /// </summary>
        public uint Priority { get; set; }
        /// <summary>
        /// WMI Property PXEPassword
        /// </summary>
        public string PxePassword { get; set; }
        /// <summary>
        /// WMI Property RateLimitsEnabled
        /// </summary>
        public bool RateLimitsEnabled { get; set; }
        /// <summary>
        /// WMI Property Region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// WMI Property ResourceType
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// WMI Property ResponseDelay
        /// </summary>
        public uint ResponseDelay { get; set; }
        /// <summary>
        /// WMI Property SccmPXE
        /// </summary>
        public bool SccmPxe { get; set; }
        /// <summary>
        /// WMI Property ServerName
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// WMI Property ServiceType
        /// </summary>
        public uint ServiceType { get; set; }
        /// <summary>
        /// WMI Property ShareName
        /// </summary>
        public string ShareName { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property SiteName
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// WMI Property SupportUnknownMachines
        /// </summary>
        public bool SupportUnknownMachines { get; set; }
        /// <summary>
        /// WMI Property TransferRate
        /// </summary>
        public uint TransferRate { get; set; }
        /// <summary>
        /// WMI Property UdaSetting
        /// </summary>
        public uint UdaSetting { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
