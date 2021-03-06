using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_MobileDeviceAgentConfig
    /// </summary>
    [WmiClass(Name = "SMS_MobileDeviceAgentConfig")]
    public class SmsMobileDeviceAgentConfig
    {
        /// <summary>
        /// WMI Property AgentID
        /// </summary>
        public uint AgentId { get; set; }
        /// <summary>
        /// WMI Property DeviceEnrollmentProfileID
        /// </summary>
        public uint DeviceEnrollmentProfileId { get; set; }
        /// <summary>
        /// WMI Property EnableDeviceEnrollment
        /// </summary>
        public uint EnableDeviceEnrollment { get; set; }
        /// <summary>
        /// WMI Property EnableFileCollection
        /// </summary>
        public bool EnableFileCollection { get; set; }
        /// <summary>
        /// WMI Property EnableHardwareInventory
        /// </summary>
        public bool EnableHardwareInventory { get; set; }
        /// <summary>
        /// WMI Property EnableModernDeviceEnrollment
        /// </summary>
        public uint EnableModernDeviceEnrollment { get; set; }
        /// <summary>
        /// WMI Property EnableSoftwareDistribution
        /// </summary>
        public bool EnableSoftwareDistribution { get; set; }
        /// <summary>
        /// WMI Property EnableSoftwareInventory
        /// </summary>
        public bool EnableSoftwareInventory { get; set; }
        /// <summary>
        /// WMI Property FailureRetryCount
        /// </summary>
        public uint FailureRetryCount { get; set; }
        /// <summary>
        /// WMI Property FailureRetryInterval
        /// </summary>
        public string FailureRetryInterval { get; set; }
        /// <summary>
        /// WMI Property FileCollectionExcludeCompressed
        /// </summary>
        public ICollection<string> FileCollectionExcludeCompressed { get; set; }
        /// <summary>
        /// WMI Property FileCollectionExcludeEncrypted
        /// </summary>
        public ICollection<string> FileCollectionExcludeEncrypted { get; set; }
        /// <summary>
        /// WMI Property FileCollectionFilter
        /// </summary>
        public ICollection<string> FileCollectionFilter { get; set; }
        /// <summary>
        /// WMI Property FileCollectionInterval
        /// </summary>
        public string FileCollectionInterval { get; set; }
        /// <summary>
        /// WMI Property FileCollectionPath
        /// </summary>
        public ICollection<string> FileCollectionPath { get; set; }
        /// <summary>
        /// WMI Property FileCollectionSubdirectories
        /// </summary>
        public ICollection<string> FileCollectionSubdirectories { get; set; }
        /// <summary>
        /// WMI Property HardwareInventoryInterval
        /// </summary>
        public string HardwareInventoryInterval { get; set; }
        /// <summary>
        /// WMI Property MDMPollInterval
        /// </summary>
        public uint MdmPollInterval { get; set; }
        /// <summary>
        /// WMI Property ModernDeviceEnrollmentProfileID
        /// </summary>
        public uint ModernDeviceEnrollmentProfileId { get; set; }
        /// <summary>
        /// WMI Property PollingInterval
        /// </summary>
        public string PollingInterval { get; set; }
        /// <summary>
        /// WMI Property PollServer
        /// </summary>
        public string PollServer { get; set; }
        /// <summary>
        /// WMI Property SoftwareInventoryExcludeCompressed
        /// </summary>
        public ICollection<string> SoftwareInventoryExcludeCompressed { get; set; }
        /// <summary>
        /// WMI Property SoftwareInventoryExcludeEncrypted
        /// </summary>
        public ICollection<string> SoftwareInventoryExcludeEncrypted { get; set; }
        /// <summary>
        /// WMI Property SoftwareInventoryFilter
        /// </summary>
        public ICollection<string> SoftwareInventoryFilter { get; set; }
        /// <summary>
        /// WMI Property SoftwareInventoryInterval
        /// </summary>
        public string SoftwareInventoryInterval { get; set; }
        /// <summary>
        /// WMI Property SoftwareInventoryPath
        /// </summary>
        public ICollection<string> SoftwareInventoryPath { get; set; }
        /// <summary>
        /// WMI Property SoftwareInventorySubdirectories
        /// </summary>
        public ICollection<string> SoftwareInventorySubdirectories { get; set; }
    }
}
