using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_OFFICE_PRODUCTINFO
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_OFFICE_PRODUCTINFO")]
    public class SmsGhSystemOfficeProductinfo
    {
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property Channel
        /// </summary>
        public string Channel { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property IsProPlusInstalled
        /// </summary>
        public uint IsProPlusInstalled { get; set; }
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// WMI Property LicenseState
        /// </summary>
        public string LicenseState { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property ProductVersion
        /// </summary>
        public string ProductVersion { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
    }
}
