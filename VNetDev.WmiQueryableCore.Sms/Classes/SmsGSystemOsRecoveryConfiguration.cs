using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_OS_RECOVERY_CONFIGURATION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_OS_RECOVERY_CONFIGURATION")]
    public class SmsGSystemOsRecoveryConfiguration
    {
        /// <summary>
        /// WMI Property AutoReboot
        /// </summary>
        public uint AutoReboot { get; set; }
        /// <summary>
        /// WMI Property Caption
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// WMI Property DebugFilePath
        /// </summary>
        public string DebugFilePath { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property KernelDumpOnly
        /// </summary>
        public uint KernelDumpOnly { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property OverwriteExistingDebugFile
        /// </summary>
        public uint OverwriteExistingDebugFile { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SendAdminAlert
        /// </summary>
        public uint SendAdminAlert { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property WriteDebugInfo
        /// </summary>
        public uint WriteDebugInfo { get; set; }
        /// <summary>
        /// WMI Property WriteToSystemLog
        /// </summary>
        public uint WriteToSystemLog { get; set; }
    }
}
