using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_SOFTWARE_SHORTCUT
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_SOFTWARE_SHORTCUT")]
    public class SmsGhSystemSoftwareShortcut
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
        /// WMI Property FilePropertiesHash
        /// </summary>
        public string FilePropertiesHash { get; set; }
        /// <summary>
        /// WMI Property FilePropertiesHashEx
        /// </summary>
        public string FilePropertiesHashEx { get; set; }
        /// <summary>
        /// WMI Property FileSize
        /// </summary>
        public uint FileSize { get; set; }
        /// <summary>
        /// WMI Property FileVersion
        /// </summary>
        public string FileVersion { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public uint Language { get; set; }
        /// <summary>
        /// WMI Property ParentName
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// WMI Property Product
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// WMI Property ProductCode
        /// </summary>
        public string ProductCode { get; set; }
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
        /// WMI Property ShortcutKey
        /// </summary>
        public string ShortcutKey { get; set; }
        /// <summary>
        /// WMI Property ShortcutName
        /// </summary>
        public string ShortcutName { get; set; }
        /// <summary>
        /// WMI Property ShortcutType
        /// </summary>
        public uint ShortcutType { get; set; }
        /// <summary>
        /// WMI Property TargetExecutable
        /// </summary>
        public string TargetExecutable { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
