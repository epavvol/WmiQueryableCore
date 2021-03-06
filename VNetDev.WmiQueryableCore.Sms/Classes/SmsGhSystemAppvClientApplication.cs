using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_GH_System_APPV_CLIENT_APPLICATION
    /// </summary>
    [WmiClass(Name = "SMS_GH_System_APPV_CLIENT_APPLICATION")]
    public class SmsGhSystemAppvClientApplication
    {
        /// <summary>
        /// WMI Property ApplicationId
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary>
        /// WMI Property EnabledForUser
        /// </summary>
        public uint EnabledForUser { get; set; }
        /// <summary>
        /// WMI Property EnabledGlobally
        /// </summary>
        public uint EnabledGlobally { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PackageId
        /// </summary>
        public string PackageId { get; set; }
        /// <summary>
        /// WMI Property PackageVersionId
        /// </summary>
        public string PackageVersionId { get; set; }
        /// <summary>
        /// WMI Property ResourceID
        /// </summary>
        public uint ResourceId { get; set; }
        /// <summary>
        /// WMI Property RevisionID
        /// </summary>
        public uint RevisionId { get; set; }
        /// <summary>
        /// WMI Property TargetPath
        /// </summary>
        public string TargetPath { get; set; }
        /// <summary>
        /// WMI Property TimeStamp
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
