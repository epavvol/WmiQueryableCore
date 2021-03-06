using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_SOFTWARE_TAG
    /// </summary>
    [WmiClass(Name = "SMS_G_System_SOFTWARE_TAG")]
    public class SmsGSystemSoftwareTag
    {
        /// <summary>
        /// WMI Property DisplayVersion
        /// </summary>
        public string DisplayVersion { get; set; }
        /// <summary>
        /// WMI Property EntitlementRequired
        /// </summary>
        public uint EntitlementRequired { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property SoftwareCreator
        /// </summary>
        public string SoftwareCreator { get; set; }
        /// <summary>
        /// WMI Property SoftwareCreatorRegid
        /// </summary>
        public string SoftwareCreatorRegid { get; set; }
        /// <summary>
        /// WMI Property SoftwareLicensor
        /// </summary>
        public string SoftwareLicensor { get; set; }
        /// <summary>
        /// WMI Property SoftwareLicensorRegid
        /// </summary>
        public string SoftwareLicensorRegid { get; set; }
        /// <summary>
        /// WMI Property TagCreator
        /// </summary>
        public string TagCreator { get; set; }
        /// <summary>
        /// WMI Property TagCreatorRegid
        /// </summary>
        public string TagCreatorRegid { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property UniqueID
        /// </summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// WMI Property VersionMajor
        /// </summary>
        public uint VersionMajor { get; set; }
        /// <summary>
        /// WMI Property VersionMinor
        /// </summary>
        public uint VersionMinor { get; set; }
    }
}
