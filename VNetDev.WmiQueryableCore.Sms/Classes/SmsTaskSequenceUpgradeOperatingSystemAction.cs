using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_TaskSequence_UpgradeOperatingSystemAction
    /// </summary>
    [WmiClass(Name = "SMS_TaskSequence_UpgradeOperatingSystemAction")]
    public class SmsTaskSequenceUpgradeOperatingSystemAction
    {
        /// <summary>
        /// WMI Property Condition
        /// </summary>
        public object Condition { get; set; }
        /// <summary>
        /// WMI Property ContinueOnError
        /// </summary>
        public bool ContinueOnError { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property DriverPackageID
        /// </summary>
        public string DriverPackageId { get; set; }
        /// <summary>
        /// WMI Property DynamicUpdateSettings
        /// </summary>
        public string DynamicUpdateSettings { get; set; }
        /// <summary>
        /// WMI Property Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// WMI Property IgnoreMessages
        /// </summary>
        public bool IgnoreMessages { get; set; }
        /// <summary>
        /// WMI Property InstallEditionIndex
        /// </summary>
        public uint InstallEditionIndex { get; set; }
        /// <summary>
        /// WMI Property InstallPackageID
        /// </summary>
        public string InstallPackageId { get; set; }
        /// <summary>
        /// WMI Property InstallPath
        /// </summary>
        public string InstallPath { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OsProductKey
        /// </summary>
        public string OsProductKey { get; set; }
        /// <summary>
        /// WMI Property PreserveSettings
        /// </summary>
        public string PreserveSettings { get; set; }
        /// <summary>
        /// WMI Property ScanOnly
        /// </summary>
        public bool ScanOnly { get; set; }
        /// <summary>
        /// WMI Property SetupTimeout
        /// </summary>
        public uint SetupTimeout { get; set; }
        /// <summary>
        /// WMI Property StagedContent
        /// </summary>
        public string StagedContent { get; set; }
        /// <summary>
        /// WMI Property SupportedEnvironment
        /// </summary>
        public string SupportedEnvironment { get; set; }
        /// <summary>
        /// WMI Property Timeout
        /// </summary>
        public uint Timeout { get; set; }
    }
}
