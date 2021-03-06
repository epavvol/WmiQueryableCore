using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_BOOT_CONFIGURATION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_BOOT_CONFIGURATION")]
    public class SmsGSystemBootConfiguration
    {
        /// <summary>
        /// WMI Property BootDirectory
        /// </summary>
        public string BootDirectory { get; set; }
        /// <summary>
        /// WMI Property ConfigurationPath
        /// </summary>
        public string ConfigurationPath { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property LastDrive
        /// </summary>
        public string LastDrive { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property ScratchDirectory
        /// </summary>
        public string ScratchDirectory { get; set; }
        /// <summary>
        /// WMI Property SettingID
        /// </summary>
        public string SettingId { get; set; }
        /// <summary>
        /// WMI Property TempDirectory
        /// </summary>
        public string TempDirectory { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
