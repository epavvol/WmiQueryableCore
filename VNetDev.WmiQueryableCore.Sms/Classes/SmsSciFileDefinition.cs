using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_SCI_FileDefinition
    /// </summary>
    [WmiClass(Name = "SMS_SCI_FileDefinition")]
    public class SmsSciFileDefinition
    {
        /// <summary>
        /// WMI Property Comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// WMI Property FileType
        /// </summary>
        public uint FileType { get; set; }
        /// <summary>
        /// WMI Property ItemName
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// WMI Property ItemType
        /// </summary>
        public string ItemType { get; set; }
        /// <summary>
        /// WMI Property OriginatingSite
        /// </summary>
        public string OriginatingSite { get; set; }
        /// <summary>
        /// WMI Property SerialNumber
        /// </summary>
        public uint SerialNumber { get; set; }
        /// <summary>
        /// WMI Property SiteCode
        /// </summary>
        public string SiteCode { get; set; }
        /// <summary>
        /// WMI Property TargetSite
        /// </summary>
        public string TargetSite { get; set; }
    }
}
