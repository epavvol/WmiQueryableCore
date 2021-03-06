using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_AUTOSTART_SOFTWARE
    /// </summary>
    [WmiClass(Name = "SMS_G_System_AUTOSTART_SOFTWARE")]
    public class SmsGSystemAutostartSoftware
    {
        /// <summary>
        /// WMI Property BinFileVersion
        /// </summary>
        public string BinFileVersion { get; set; }
        /// <summary>
        /// WMI Property BinProductVersion
        /// </summary>
        public string BinProductVersion { get; set; }
        /// <summary>
        /// WMI Property Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// WMI Property FileName
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// WMI Property FilePropertiesHash
        /// </summary>
        public string FilePropertiesHash { get; set; }
        /// <summary>
        /// WMI Property FilePropertiesHashEx
        /// </summary>
        public string FilePropertiesHashEx { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Location
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// WMI Property Product
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property StartupType
        /// </summary>
        public string StartupType { get; set; }
        /// <summary>
        /// WMI Property StartupValue
        /// </summary>
        public string StartupValue { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
