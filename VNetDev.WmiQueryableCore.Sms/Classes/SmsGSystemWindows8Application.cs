using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_G_System_WINDOWS8_APPLICATION
    /// </summary>
    [WmiClass(Name = "SMS_G_System_WINDOWS8_APPLICATION")]
    public class SmsGSystemWindows8Application
    {
        /// <summary>
        /// WMI Property ApplicationName
        /// </summary>
        public string ApplicationName { get; set; }
        /// <summary>
        /// WMI Property Architecture
        /// </summary>
        public string Architecture { get; set; }
        /// <summary>
        /// WMI Property ConfigMgrManaged
        /// </summary>
        public uint ConfigMgrManaged { get; set; }
        /// <summary>
        /// WMI Property DependencyApplicationNames
        /// </summary>
        public string DependencyApplicationNames { get; set; }
        /// <summary>
        /// WMI Property FamilyName
        /// </summary>
        public string FamilyName { get; set; }
        /// <summary>
        /// WMI Property FullName
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// WMI Property GroupID
        /// </summary>
        public uint GroupId { get; set; }
        /// <summary>
        /// WMI Property InstalledLocation
        /// </summary>
        public string InstalledLocation { get; set; }
        /// <summary>
        /// WMI Property IsFramework
        /// </summary>
        public uint IsFramework { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property PublisherId
        /// </summary>
        public string PublisherId { get; set; }
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
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
